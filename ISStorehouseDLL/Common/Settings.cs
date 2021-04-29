using ISStorehouseDLL.Models;
using NLog;
using Realms;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ISStorehouseDLL.Common
{
    public class Settings
    {
        private Modbus _modbus = new Modbus();
        private ScanClass _scan = new ScanClass();
        private CancellationTokenSource _tokenSource = new CancellationTokenSource();
        protected Logger _logger = LogManager.GetCurrentClassLogger();
        private int ErrorCount;
        private short LastReadModuleID;

        #region ENUMS
        public enum Status
        {
            Disabled,    //0
            Active,      //1
            Diagnose     //2 
        }

        public enum BaseColors
        {
            Red = 1,            // 1
            Green = 2,          // 2
            Blue = 3,           // 3
        }

        public enum Colors
        {
            Black,          // 0
            Red,            // 1
            Green,          // 2
            Blue,           // 3
            Yellow,         // 4
            Aqua,           // 5
            Magenda,        // 6
            White           // 7
        }

        public enum Respond
        {
            OK = 200,
            Bad_Request = 500,
        }

        public enum Effects
        {
            NoEffect,             // 0
            Blink,                // 1
            DoubleBlink,          // 2
        }

        #endregion

        public void SavePort(string com)
        {
            var realm = Realm.GetInstance();
            var PortTable = realm.All<Port>();

            if (PortTable != null)
            {
                foreach (var port in PortTable)
                {
                    realm.Write(() =>
                    {
                        realm.Remove(port);

                    });

                }
            }
            realm.Write(() =>
            {
                realm.Add(new Port()
                {
                    ComPort = com,
                    CreatedDate = DateTimeOffset.Now,
                });
            });

            realm.Dispose();
            OpenPort();

        }

        private void OpenPort()
        {
            var realm = Realm.GetInstance();
            var COM = realm.All<Port>().FirstOrDefault().ComPort;

            var Baud = "9600";
            try
            {
                _modbus.Open(COM, Convert.ToInt32(Baud), 8, System.IO.Ports.Parity.None, System.IO.Ports.StopBits.One);

            }
            catch (Exception ex)
            {
                var message = ex;
            }

            realm.Dispose();
        }

        public async Task AllModulsDiagnose(CancellationToken token)
        {
            var realm = Realm.GetInstance();

            short[] Errors;
            var ignoreModul = realm.All<Moduls>().FirstOrDefault(
                x => x.Status == 0);

            var Modul = realm.All<Moduls>().Where(
                x => x.Status != 0);


            foreach (var mod in Modul)
            {
                realm.Write(() =>
                {
                    mod.Status = Convert.ToInt32(Status.Diagnose);
                });
            }

            if (ignoreModul != null)
            {
                var storehouses = realm.All<Moduls>();
                foreach (var store in storehouses)
                {
                    foreach (BaseColors colors in (BaseColors[])Enum.GetValues(typeof(BaseColors)))
                    {
                        if (store.Module != ignoreModul.Module)
                        {
                            for (int i = 0; i <= store.Collumns; i++)
                            {
                                for (int j = 0; j <= store.Rows; j++)
                                {
                                    var diags = realm.All<Storehouse>().FirstOrDefault(
                                        x => x.Module == store.Module && x.Collumn == i && x.Row == j);
                                    realm.Write(() =>
                                    {
                                        diags.Color1 = Convert.ToByte(colors);
                                        diags.Color2 = Convert.ToByte(Colors.Black);
                                        diags.Effect = Convert.ToByte(Effects.NoEffect);
                                        diags.Modify = true;

                                    });

                                    if (token.IsCancellationRequested)
                                    {
                                        foreach (var mod in Modul)
                                        {
                                            realm.Write(() =>
                                            {
                                                mod.Status = Convert.ToInt32(Status.Active);
                                            });
                                        }
                                        _scan.ClearOneModul(store.Module);
                                        return;
                                    }
                                    Thread.Sleep(200);


                                }
                                Thread.Sleep(200);

                                for (int j = 0; j <= store.Rows; j++)
                                {

                                    var diags = realm.All<Storehouse>().FirstOrDefault(
                                        x => x.Module == store.Module && x.Collumn == i && x.Row == j);
                                    realm.Write(() =>
                                    {
                                        diags.Color1 = Convert.ToByte(Colors.Black);
                                        diags.Color2 = Convert.ToByte(Colors.Black);
                                        diags.Effect = Convert.ToByte(Effects.NoEffect);
                                        diags.Modify = true;
                                    });

                                }
                            }
                        }
                    }
                }

                var moduls = realm.All<Storehouse>();
                foreach (var modul in moduls)
                {
                    realm.Write(() =>
                    {
                        modul.Color1 = Convert.ToByte(Colors.Black);
                        modul.Color2 = Convert.ToByte(Colors.Black);
                        modul.Effect = Convert.ToByte(Effects.NoEffect);
                    });
                }

            }
            else
            {
                var storehouses = realm.All<Moduls>();

                foreach (var store in storehouses)
                {
                    foreach (BaseColors colors in (BaseColors[])Enum.GetValues(typeof(BaseColors)))
                    {
                        for (int i = 0; i <= store.Collumns; i++)
                        {
                            for (int j = 0; j <= store.Rows; j++)
                            {

                                var diags = realm.All<Storehouse>().FirstOrDefault(
                                    x => x.Module == store.Module && x.Collumn == i && x.Row == j);
                                realm.Write(() =>
                                {
                                    diags.Color1 = Convert.ToByte(colors);
                                    diags.Color2 = Convert.ToByte(Colors.Black);
                                    diags.Effect = Convert.ToByte(Effects.NoEffect);
                                    diags.Modify = true;

                                });
                                if (token.IsCancellationRequested)
                                {
                                    foreach (var mod in Modul)
                                    {
                                        realm.Write(() =>
                                        {
                                            mod.Status = Convert.ToInt32(Status.Active);
                                        });
                                    }
                                    _scan.ClearOneModul(store.Module);
                                    return;
                                }
                                Thread.Sleep(200);
                            }


                            Thread.Sleep(200);

                            for (int j = 0; j <= store.Rows; j++)
                            {

                                var diags = realm.All<Storehouse>().FirstOrDefault(
                                    x => x.Module == store.Module && x.Collumn == i && x.Row == j);
                                realm.Write(() =>
                                {
                                    diags.Color1 = Convert.ToByte(Colors.Black);
                                    diags.Color2 = Convert.ToByte(Colors.Black);
                                    diags.Effect = Convert.ToByte(Effects.NoEffect);
                                    diags.Modify = true;
                                });

                            }
                        }

                    }
                }

                Thread.Sleep(3000);

                var moduls = realm.All<Storehouse>();

                foreach (var modul in moduls)
                {
                    realm.Write(() =>
                    {
                        modul.Color1 = Convert.ToByte(Colors.Black);
                        modul.Color2 = Convert.ToByte(Colors.Black);
                        modul.Effect = Convert.ToByte(Effects.NoEffect);
                    });
                }

            }

            Diagnosis();
        }

        public void OneModulTest(short modul, CancellationToken token)
        {
            var realm = Realm.GetInstance();

            var Deposit = realm.All<Moduls>().FirstOrDefault(
                x => x.Module == modul);

            realm.Write(() =>
            {
                Deposit.Status = Convert.ToInt32(Status.Diagnose);
            });

            foreach (BaseColors colors in (BaseColors[])Enum.GetValues(typeof(BaseColors)))
            {
                for (int j = 0; j <= Deposit.Collumns; j++)
                {

                    for (int i = 0; i <= Deposit.Rows; i++)
                    {
                        var Storehouse = realm.All<Storehouse>().FirstOrDefault(
                            x => x.Collumn == j && x.Row == i);

                        realm.Write(() =>
                        {
                            Deposit.Status = Convert.ToInt32(Status.Diagnose);
                            Storehouse.Color1 = Convert.ToByte(colors);
                            Storehouse.Color2 = Convert.ToByte(Colors.Black);
                            Storehouse.Effect = Convert.ToByte(Effects.NoEffect);
                            Storehouse.Modify = true;
                        });

                        if (token.IsCancellationRequested)
                        {
                            realm.Write(() =>
                            {
                                Deposit.Status = Convert.ToInt32(Status.Active);
                            });

                            _scan.ClearOneModul(modul);
                            return;
                        }
                    }
                    Thread.Sleep(1000);

                    for (int i = 0; i <= Deposit.Rows; i++)
                    {
                        var Storehouse = realm.All<Storehouse>().FirstOrDefault(
                        x => x.Collumn == j && x.Row == i);

                        realm.Write(() =>
                        {
                            Storehouse.Color1 = Convert.ToByte(Colors.Black);
                            Storehouse.Color2 = Convert.ToByte(Colors.Black);
                            Storehouse.Effect = Convert.ToByte(Effects.NoEffect);
                            Storehouse.Modify = true;
                        });
                    }

                }

            }

            Thread.Sleep(5000);

            var Moduls = realm.All<Storehouse>();

            for (int j = 0; j <= Deposit.Collumns; j++)
            {
                for (int i = 0; i <= Deposit.Rows; i++)
                {
                    var Storehouse = realm.All<Storehouse>().FirstOrDefault(
                    x => x.Collumn == j && x.Row == i);

                    realm.Write(() =>
                    {
                        Storehouse.Color1 = Convert.ToByte(Colors.Black);
                        Storehouse.Color2 = Convert.ToByte(Colors.Black);
                        Storehouse.Effect = Convert.ToByte(Effects.NoEffect);
                        Storehouse.Modify = true;
                    });
                }
            }

            foreach (var moduls in Moduls)
            {
                realm.Write(() =>
                {
                    moduls.Color1 = Convert.ToByte(Colors.Black);
                    moduls.Color2 = Convert.ToByte(Colors.Black);
                    moduls.Effect = Convert.ToByte(Effects.NoEffect);
                });
            }

            realm.Write(() =>
            {
                Deposit.Status = Convert.ToInt32(Status.Active);
            });

            return;
        }

        public void CheckDataBase()
        {
            OpenPort();
            var realm = Realm.GetInstance();

            do
            {
                realm.Refresh();
                var CheckTable = realm.All<Storehouse>();

                foreach (var check in CheckTable)
                {
                    var LedsPerRow = realm.All<Moduls>().FirstOrDefault(
                        x => x.Module == check.Module);
                    try
                    {
                        if (check.Modify)
                        {
                            _modbus.WriteSingle(
                                Convert.ToInt32(check.Module),
                                Convert.ToInt16(check.Row),
                                Convert.ToUInt16(LedsPerRow.Collumns),
                                Convert.ToInt16(check.Collumn),
                                Convert.ToByte(check.Effect),
                                Convert.ToByte(check.Color1),
                                Convert.ToByte(check.Color2));

                            realm.Write(() =>
                            {
                                check.Modify = false;
                            });
                        }

                    }
                    catch (Exception ex)
                    {
                        var exception = ex;
                    }

                }
            }
            while (true);
        }

        public void Diagnosis()
        {
            var realm = Realm.GetInstance();
            var ErrorsTable = realm.All<Errors>();

            short[] Row;

            foreach (var Error in ErrorsTable)
            {
                Row = _modbus.PollFunction(Error.Module, 0, 10);

                var AllModuls = realm.All<Moduls>().FirstOrDefault(
                    x => x.Module == Error.Module);

                if (Row != null)
                {
                    realm.Write(() =>
                    {
                        Error.OverflowErrCount = Convert.ToInt16(Row[4]);
                        Error.IlegalDataValueCount = Convert.ToInt16(Row[5]);
                        Error.IlegalDataAddressCount = Convert.ToInt16(Row[6]);
                        Error.IlegatFunctionCount = Convert.ToInt16(Row[7]);
                        Error.CheckSumErrCount = Convert.ToInt16(Row[8]);
                        Error.TotoalErr = Convert.ToInt16(Row[9]);
                    });

                    if (Row[0] != AllModuls.Module || Error.OverflowErrCount != 0 || Error.IlegalDataValueCount != 0 || Error.IlegalDataAddressCount != 0 || Error.IlegatFunctionCount != 0 || Error.CheckSumErrCount != 0)
                    {
                        realm.Write(() =>
                        {
                            AllModuls.Status = Convert.ToInt32(Status.Disabled);
                        });
                    }
                    else
                    {
                        realm.Write(() =>
                        {
                            AllModuls.Status = Convert.ToInt32(Status.Active);
                        });
                    }
                }

            }

            realm.Dispose();
        }

        public string FirstScanDeposit(int FromModule, int ToModule)
        {
            var realm = Realm.GetInstance();
            var AllModuls = realm.All<Moduls>();
            var AllAddreses = realm.All<Storehouse>();
            var Error = realm.All<Errors>();
            string Message;
            short[] Row;
            short[] Errors;

            if (AllModuls != null)
            {
                foreach (var addreses in AllAddreses)
                {
                    realm.Write(() =>
                    {
                        realm.Remove(addreses);

                    });
                }

                foreach (var moduls in AllModuls)
                {
                    realm.Write(() =>
                    {
                        realm.Remove(moduls);

                    });
                }

                foreach (var errors in Error)
                {
                    realm.Write(() =>
                    {
                        realm.Remove(errors);

                    });
                }
            }

            for (int i = FromModule, loopTo = ToModule; i <= loopTo; i++)
            {
                try
                {
                    Row = _modbus.PollFunction(i, 0, 10);
                    if (Row is object)
                    {
                        realm.Write(() =>
                        {
                            realm.Add(new Moduls()
                            {
                                Module = Row[0],
                                Rows = Row[1],
                                Collumns = Row[2],
                                CreationTime = DateTimeOffset.Now,
                                ModifyTime = DateTimeOffset.Now,
                            });
                        });
                    }
                }
                catch (Exception ex)
                {
                }
            }

            var Deposit = realm.All<Moduls>();

            foreach (var modul in Deposit)
            {
                realm.Write(() =>
                {
                    realm.Add(new Errors()
                    {
                        Module = modul.Module,
                        Rows = modul.Rows,
                        Collumns = modul.Collumns,

                    });
                });
            }

            foreach (var moduls in Deposit)
            {
                try
                {
                    Errors = _modbus.PollFunction(Convert.ToInt32(moduls.Module), 0, 10);

                    var AllErrors = realm.All<Errors>().FirstOrDefault(
                        x => x.Module == Errors[0] &&
                        x.Rows == Errors[1] &&
                        x.Collumns == Errors[2]
                );

                    realm.Write(() =>
                    {
                        moduls.RegModule = Convert.ToInt16(Errors[0]);
                        AllErrors.OverflowErrCount = Convert.ToInt16(Errors[4]);
                        AllErrors.IlegalDataValueCount = Convert.ToInt16(Errors[5]);
                        AllErrors.IlegalDataAddressCount = Convert.ToInt16(Errors[6]);
                        AllErrors.IlegatFunctionCount = Convert.ToInt16(Errors[7]);
                        AllErrors.CheckSumErrCount = Convert.ToInt16(Errors[8]);
                        AllErrors.TotoalErr = Convert.ToInt16(Errors[9]);
                        AllErrors.Created = DateTimeOffset.Now;
                        moduls.Status = Convert.ToInt16(Status.Active);
                    });

                    _logger.Info("Module " + Errors[0] + "OverflowErrCount" + Errors[4] + "IlegalDataValueCount" + Errors[5] + "IlegalDataAddressCount" + Errors[6] + "IlegatFunctionCount" + Errors[7] + "CheckSumErrCount" + Errors[8] + "TotoalErrCreated" + Errors[9]);


                    if (Errors[4] != 0 || Errors[5] != 0 || Errors[6] != 0 || Errors[7] != 0 || Errors[8] != 0)
                    {
                        realm.Write(() =>
                        {
                            moduls.Status = Convert.ToInt16(Status.Disabled);
                        });
                    }


                }

                catch (Exception ex)
                {
                    var exception = ex;
                }

            }
            _scan.DisplayModules();
            realm.Dispose();
            Message = "Scan finished";
            return Message;
        }

        public string Cancel(CancellationToken token)
        {
            _tokenSource.Cancel();
            return "Canceled";
        }

    }
}
