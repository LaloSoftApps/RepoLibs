. .\Configuration.ps1

#####################################################################
. .\ClassDB.ps1

# Armamos la Query y llamamos al metodo
$Query = "SELECT TOP 5 * FROM TABLE"
$Data = $DBConn::Exec($Query)

# REcorremos el DataSet devuelto y lo mostramos
ForEach ($Registro in $Data.Tables[0]) { 
    Write-Host $Registro.CampoXXXX
}


#####################################################################




