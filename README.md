# Proyecto ISCAV <img align="right" src="https://github.com/siorellana/iscav_desktop/blob/master/Reportes/Logo.png">
- Website: https://iscav-web.com
- TO-ADD Badges

Este proyecto forma parte del examen de grado presentado a INACAP con el fin de crear un proyecto de reconocimiento facial para el aseguramiento del control de acceso de personas, como medida de prevención de delitos y herramienta de apoyo para los conserjes y encargados de seguridad de los edificios.

# Getting started
- Primero obviamente descarga el repositorio.
- Realizar la recuperación del archivo .bak en el motor SQL Server (versiones mas abajo).
- Abrir el archivo .sln con Visual Studio (no Visual Studio Code).
- Credenciales de acceso admin/admin1
- El modulo de enrrolamiento permite enrolarte.
- El modulo Real Time Iscav permite verificar tu identidad.

## Consideraciones
Al ser un proyecto de C#, se debe ejecutar en un entorno Windows. En caso de que no usea Windows (como yo), crear una máquina virtual con Windows 10 y realizar los pasos antes descritos.

# OpenCV: Open Source Computer Vision Library
### Resources
- Homepage: https://opencv.org
- Docs: https://docs.opencv.org/master/
- Q&A forum: http://answers.opencv.org
- Issue tracking: https://github.com/opencv/opencv/issues
### Contributing
Please read the contribution guidelines before starting work on a pull request.

### Summary of the guidelines:
 - One pull request per issue;
 - Choose the right base branch;
 - Include tests and documentation;
 - Clean up "oops" commits before submitting;
 - Follow the coding style guide.

 
 
# SQL Server
La base de datos que contiene la base de datos del sistema Iscav Desktop se llama iscavDB.
Se esta utilizando:
- Microsoft SQL Server 2017 (RTM) - 14.0.1000.169 (X64).
- Management Studio 2017 versión 17.8.1 que se puede obtener desde el siguiente link:
 
https://docs.microsoft.com/es-es/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-2017
 
Se han dejado las bases de datos en los directorios:
 - C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\
 - C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\Log\
 
El string de conexión debe ser con localhost como se muestra a continuación:
 
```
private static string cadenaConexion = @"Data Source=localhost;Initial Catalog=dbprod1;Trusted_Connection =True";
```

# License

See the [LICENSE](LICENSE) file for license rights and limitations (MIT).


* Producción: https://iscav-web.com
* Desarrollo: https://iscav-dev.firebaseapp.com
* Legacy 2.0: https://iscav-web.firebaseapp.com
