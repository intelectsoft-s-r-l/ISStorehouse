﻿using ISStorehouseDLL.Models;
using Realms;
using System;
using System.Linq;
using System.Threading;

namespace ISStorehouseDLL.Common
{
    public class Settings
    {
        private Modbus modbus = new Modbus();
        private ScanClass scan = new ScanClass();
        private int ErrorCount;
        private short LastReadModuleID;

        public enum Status
        {
            Disabled,    //0
            Active       //1
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
            White           // 6
        }

        public enum Effects
        {
            NoEffect,             // 0
            Blink,                // 1
            DoubleBlink,          // 2
        }

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
            var COM = realm.All<Port>();

            var Com = "COM5";
            var Baud = "9600";
            modbus.Open(Com, Convert.ToInt32(Baud), 8, System.IO.Ports.Parity.None, System.IO.Ports.StopBits.One);

            realm.Dispose();
        }
        private void ClosePort()
        {
            modbus.Close();
        }

        //TODO: CRITICAL!!!!!!!!!  AllModulsDiagnose need fix, or StoreHouse Will DIE!!!!!!!!
        public string AllModulsDiagnose()
        {
            ClosePort();
            OpenPort();
            var realm = Realm.GetInstance();
            var Deposit = realm.All<Moduls>();
            short[] Errors;
            var ignoreModul = realm.All<Moduls>().FirstOrDefault(
                x => x.Status == 0);

            if (ignoreModul != null)
            {
                foreach (Colors colors in (Colors[])Enum.GetValues(typeof(Colors)))
                {
                    foreach (var deposit in Deposit)
                    {
                        if (deposit.Module != ignoreModul.Module)
                        {
                            for (int i = 0; i <= deposit.Rows; i++)
                            {
                                for (int j = 0; j <= deposit.Collumns; j++)
                                {
                                    modbus.WriteSingle(Convert.ToInt32(deposit.Module),
                                        Convert.ToInt16(i),
                                        Convert.ToUInt16(deposit.Collumns),
                                        Convert.ToInt16(j),
                                        Convert.ToByte(Effects.NoEffect),
                                        Convert.ToByte(colors),
                                        Convert.ToByte(Colors.Black));
                                }
                            }
                        }

                    }
                }

                Thread.Sleep(5000);

                var moduls = realm.All<Storehouse>();
                foreach (var deposit in Deposit)
                {
                    if (deposit.Module != ignoreModul.Module)
                    {
                        for (int i = 0; i <= deposit.Rows; i++)
                        {
                            for (int j = 0; j <= deposit.Collumns; j++)
                            {
                                modbus.WriteSingle(Convert.ToInt32(deposit.Module),
                                    Convert.ToInt16(i),
                                    Convert.ToUInt16(deposit.Collumns),
                                    Convert.ToInt16(j),
                                    Convert.ToByte(Effects.NoEffect),
                                    Convert.ToByte(Colors.Black),
                                    Convert.ToByte(Colors.Black));
                            }
                        }
                    }

                }

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
                foreach (Colors colors in (Colors[])Enum.GetValues(typeof(Colors)))
                {
                    foreach (var deposit in Deposit)
                    {
                        for (int i = 0; i <= deposit.Rows; i++)
                        {
                            for (int j = 0; j <= deposit.Collumns; j++)
                            {
                                modbus.WriteSingle(Convert.ToInt32(deposit.Module),
                                    Convert.ToInt16(i),
                                    Convert.ToUInt16(deposit.Collumns),
                                    Convert.ToInt16(j),
                                    Convert.ToByte(Effects.NoEffect),
                                    Convert.ToByte(colors),
                                    Convert.ToByte(Colors.Black));
                            }
                        }


                    }
                }

                Thread.Sleep(3000);

                var moduls = realm.All<Storehouse>();

                foreach (var deposit in Deposit)
                {
                    for (int i = 0; i <= deposit.Rows; i++)
                    {
                        for (int j = 0; j <= deposit.Collumns; j++)
                        {
                            modbus.WriteSingle(Convert.ToInt32(deposit.Module),
                                Convert.ToInt16(i),
                                Convert.ToUInt16(deposit.Collumns),
                                Convert.ToInt16(j),
                                Convert.ToByte(Effects.NoEffect),
                                Convert.ToByte(Colors.Black),
                                Convert.ToByte(Colors.Black));
                        }
                    }
                }

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
            ClosePort();

            string Message = "Diagnose ended";
            return Message;
        }

        public void OneModulTest(short modul)
        {
            OpenPort();

            var realm = Realm.GetInstance();
            var ModuleId = modul;
            var Deposit = realm.All<Moduls>();

            foreach (Colors colors in (Colors[])Enum.GetValues(typeof(Colors)))
            {
                foreach (var deposit in Deposit)
                {
                    for (int i = 0; i <= deposit.Rows; i++)
                    {
                        for (int j = 0; j <= deposit.Collumns; j++)
                        {
                            modbus.WriteSingle(Convert.ToInt32(ModuleId),
                                Convert.ToInt16(i),
                                Convert.ToUInt16(deposit.Collumns),
                                Convert.ToInt16(j),
                                Convert.ToByte(Effects.NoEffect),
                                Convert.ToByte(colors),
                                Convert.ToByte(Colors.Black));
                        }
                    }
                }
            }

            Thread.Sleep(5000);

            var Moduls = realm.All<Storehouse>();

            foreach (var deposit in Deposit)
            {
                for (int i = 0; i <= deposit.Rows; i++)
                {
                    for (int j = 0; j <= deposit.Collumns; j++)
                    {
                        modbus.WriteSingle(Convert.ToInt32(ModuleId),
                            Convert.ToInt16(i),
                            Convert.ToUInt16(deposit.Collumns),
                            Convert.ToInt16(j),
                            Convert.ToByte(Effects.NoEffect),
                            Convert.ToByte(Colors.Black),
                            Convert.ToByte(Colors.Black));
                    }
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
                            modbus.WriteSingle(
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
                Row = modbus.PollFunction(Error.Module, 0, 10);

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
                    Row = modbus.PollFunction(i, 0, 10);
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
                    Errors = modbus.PollFunction(Convert.ToInt32(moduls.Module), 0, 10);

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
            scan.DisplayModules();
            realm.Dispose();
            Message = "Scan finished";
            return Message;
        }
    }
}
