        '* Declare the main type that matches the UDT to write to
        Dim rm As RawMaterialType
        rm.RawMaterialID = "Copper"
        rm.TimeStarted.Year = 2017
        rm.TimeStarted.Month = 7
        rm.TimeStarted.Day = 15

        rm.Location = 11
        rm.Tolerance = 0.5
        rm.TargetWeight = 100

        '* Since an Array within a Structure points to an array, we create that array, then assign the
        '* Structure variable to it
        Dim li(2) As LotInformationType
        li(0).ActualWeight = 1
        li(0).LotNumber = "ABCDEF"
        li(0).ExpirationDate = "12/31/2050"
        rm.LotInformation = li

        EthernetIPforCLXCom1.WriteUDT("MyRawMaterial", rm)
