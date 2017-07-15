Public Structure RawMaterialType
    Dim RawMaterialID As String
    Dim Location As Int32
    Dim TargetWeight As Single
    Dim Tolerance As Single
    Dim _Optional As Boolean
    Dim ActualWeight As Single

    '* Structures use a pointer to an array, so you cannot define length here
    Dim LotInformation() As LotInformationType

    Dim TimeStarted As DateTimeType
    Dim TimeCompleted As DateTimeType
    Dim HandStationUsed As Int32
End Structure
