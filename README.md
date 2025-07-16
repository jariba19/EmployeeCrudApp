Proyecto de gesti�n de empleados .NET Core con Razor Pages.

1. Se ha utilizado una arquitectura DDD para que sea una aplicaci�n mas mantenible y escalable. 
	- En el caso de un CRUD simple no ser�a necesaria una arquitectura de este tipo debido a su complejidad pero lo he decidido 
	hacer as� como ejemplo para una aplicaci�n de m�s envergadura.
2. Se ha a�adido una capa de seguridad con JWT
	- Se ha decidido a�adir seguridad ya que en aplicaciones que puedan contener informaci�n personal, en este caso de empleados, 
	es susceptible de recibir un ataque e impide que cualquier persona pueda acceder a esos datos.
	- Usuario de test "admin", con contrase�a "Welcome.01" (est� incluido en Program.cs)
3. La soluci�n incluye una base de datos ligera Sqlite
	- Al ser un proyecto de prueba no he creido conveniente incluir bases de datos m�s pesadas.
4. No he incluido un proyecto de testing
	- No est� incluido ya que no hay l�gica m�s all� del almacenamiento de datos ni l�gica extra
	- Ser�a recomendable incluirlo si fuese un proyecto real, en producci�n, hubiese reglas de negocio y como buenas practicas.