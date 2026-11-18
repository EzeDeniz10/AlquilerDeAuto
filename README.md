Sistema de Gestión de Alquiler de Vehículos

Aplicación de gestión desarrollada en C# / .NET aplicando principios de arquitectura en capas para desacoplar la lógica de negocio del acceso a datos y la interfaz de usuario. El sistema permite administrar de manera integral la flota de vehículos, el registro de clientes y el ciclo de vida de los alquileres.

Arquitectura del Proyecto

El proyecto está estructurado separando responsabilidades para facilitar el mantenimiento, la escalabilidad y las pruebas unitarias:

AlquilerDeAuto.AccesoDeDatos: Capa encargada de la comunicación directa con la base de datos (operaciones CRUD, ejecución de consultas y mapeo de entidades).

Capa de Lógica de Negocio / Entidades: Validaciones de disponibilidad de vehículos, cálculo de tarifas por días de alquiler y reglas del dominio.

Capa de Presentación: Interfaz de usuario intuitiva para la operación diaria del personal administrativo.

Funcionalidades Principales

Gestión de Flota (ABM): Alta, baja, modificación y consulta de vehículos (marca, modelo, patente, categoría, estado de disponibilidad y tarifa diaria).

Gestión de Clientes: Registro y administración de datos de clientes habilitados para alquilar.

Control de Reservas y Alquileres:

Verificación automática de disponibilidad de unidades por rango de fechas.

Cálculo dinámico de costos según duración del contrato.

Registro de entregas y devoluciones con actualización de estado de la unidad.

Tecnologías Utilizadas

Lenguaje: C#

Framework: .NET

Base de Datos: SQL Server / Base de datos relacional

Control de Versiones: Git & GitHub

Instalación y Ejecución Local

Clonar el repositorio:

git clone https://github.com/EzeDeniz10/AlquilerDeAuto.git


Abrir el archivo de solución (.sln) en Visual Studio.

Configurar la cadena de conexión (ConnectionString) en el archivo de configuración (App.config o appsettings.json) apuntando a tu instancia local de base de datos.

Ejecutar el script de creación de tablas incluido en el repositorio (si corresponde) o restaurar la base de datos.

Compilar la solución y ejecutar el proyecto principal (F5).

Autor

Ezequiel Deniz — Desarrollador de Software

Email: Ezequieldeniz10@gmail.com

Capitán Bermúdez / Rosario, Santa Fe, Argentina
