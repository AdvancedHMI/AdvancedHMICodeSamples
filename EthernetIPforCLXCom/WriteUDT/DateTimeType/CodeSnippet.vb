        Dim dt As DateTimeType
        dt.Year = 2017
        dt.Month = 7
        dt.Day = 15
        dt.Hour = 10
        dt.Minute = 15
        dt.Second = 30
        dt.Microseconds = 100

        EthernetIPforCLXCom1.WriteUDT("MyDate", dt)
