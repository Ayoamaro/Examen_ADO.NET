# Examen de ADO.NET en Visual Studio

Realiza formularios de **ADO.NET** utilizando **Visual Studio** y el **lenguaje C#**, accediendo a la base de datos de SQL Server Concesionario.

El nombre del proyecto **exaConcesionario_NombreAlumno**. Deberá aparecer tu nombre en la ejecución y como comentario en cada uno de los ficheros del proyecto.

La clave de la tabla **tipo_vehiculo** es **char(3)** y la clave de la tabla **vehiculo** es **char(8)**.
Entre la tabla **tipo_vehiculo** y **vehiculo** la relación es de uno a muchos. Un vehículo tendrá un solo **tipo_vehiculo**, pero un **tipo_vehiculo** podrá tener varios vehículos.

Menu Principal de la aplicación:

![](https://github.com/Ayoamaro/Examen_ADO.NET/blob/main/docs/images/mainMenu.PNG?raw=true)

Añádele al proyecto los siguientes **5 formularios**:

1. Primer formulario: Utilizar el **DataReader** con **DataGrid**. Usando la tabla **vehiculo**.

![](https://github.com/Ayoamaro/Examen_ADO.NET/blob/main/docs/images/readLogs.PNG?raw=true)

2. Segundo formulario: Utilizar dentro de un **DataGrid** una de sus columnas que sean un **ComboBox**. Usando la tabla **tipo_vehiculo** y **vehiculo**.

![](https://github.com/Ayoamaro/Examen_ADO.NET/blob/main/docs/images/comboDataGrid.PNG?raw=true)

3. Tercer formulario: Hacer algún borrado de registro de tabla, mostrar los datos antes del borrado en varios **TextBox**, **CheckBox**... Usando la tabla **vehiculo**.

![](https://github.com/Ayoamaro/Examen_ADO.NET/blob/main/docs/images/deleteLogs.PNG?raw=true)

4. Cuarto formulario: Seleccionar una celda de un **DataGrid** y en otra ventana los registros relacionados indicando también los valores del primer **DataGrid**. Utilizar **DataRelations**. Usando la tabla **tipo_vehiculo** y **vehiculo**.

![](https://github.com/Ayoamaro/Examen_ADO.NET/blob/main/docs/images/twoDataGridRelation.PNG?raw=true)

5. Quinto formulario: Ejecutar el procedimiento (**listavehiculos**) y la función de la base de datos (**Numerovehiculosportipo**)

![](https://github.com/Ayoamaro/Examen_ADO.NET/blob/main/docs/images/executePyF.PNG?raw=true)

Controlar las exepciones que se puenda producri, los datos de conexión de la base de datos estarán en un solo fichero (clase) y realizar un menú de opciones para probar los formularios anteriores.
