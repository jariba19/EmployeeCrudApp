Proyecto de gestión de empleados .NET Core con Razor Pages.

1. Se ha utilizado una arquitectura DDD para que sea una aplicación mas mantenible y escalable. 
	- En el caso de un CRUD simple no sería necesaria una arquitectura de este tipo debido a su complejidad pero lo he decidido 
	hacer así como ejemplo para una aplicación de más envergadura.
2. Se ha añadido una capa de seguridad con JWT
	- Se ha decidido añadir seguridad ya que en aplicaciones que puedan contener información personal, en este caso de empleados, 
	es susceptible de recibir un ataque e impide que cualquier persona pueda acceder a esos datos.
	- Usuario de test "admin", con contraseña "Welcome.01" (está incluido en Program.cs)
3. La solución incluye una base de datos ligera Sqlite
	- Al ser un proyecto de prueba no he creido conveniente incluir bases de datos más pesadas.
4. No he incluido un proyecto de testing
	- No está incluido ya que no hay lógica más allá del almacenamiento de datos ni lógica extra
	- Sería recomendable incluirlo si fuese un proyecto real, en producción, hubiese reglas de negocio y como buenas practicas.