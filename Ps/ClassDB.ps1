$DllFile = ".\bin\LibDB.dll"
Add-Type -Path $DllFile
$DBConn = [LibDB.DBSqlConn]

# Definimos Propiedades de la clase de conexion
$DBConn::DBServer = $DbServer
$DBConn::DBName = $DbName
$DBConn::DBUser = $DbUser
$DBConn::DBUserPwd = $DbUserPwd
