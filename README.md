# 🧍‍♂️ Registro Comunitario – Práctica Semana 7

Aplicación web desarrollada en **ASP.NET Core MVC (.NET 8)** como práctica académica de la materia **Programación 3**.  
Permite **registrar participantes**, almacenarlos **en memoria**, y mostrarlos en una tabla dinámica con validaciones y diseño profesional basado en **Bootstrap 5**.

---

## 📸 Capturas de pantalla

### 🏠 Página principal
![Home](<img width="1694" height="1277" alt="image" src="https://github.com/user-attachments/assets/08b1f8cb-d039-4f84-b044-5cf25d700b2b" />)

### 📝 Formulario de registro
![Formulario](<img width="1350" height="1270" alt="image" src="https://github.com/user-attachments/assets/077453bf-1615-472b-a2e1-2fe80d85f9b6" />)

### 📋 Listado de participantes
![Listado](<img width="1343" height="1267" alt="image" src="https://github.com/user-attachments/assets/bbcae54c-0bc4-4ca2-9d1a-972593258e21" />)

---

## 🚀 Tecnologías utilizadas

| Componente | Descripción |
|-------------|-------------|
| **.NET 8 (ASP.NET Core MVC)** | Framework principal de desarrollo |
| **C# 10** | Lenguaje de programación |
| **Razor Views** | Motor de vistas para renderizar HTML dinámico |
| **Bootstrap 5.3** | Framework CSS para diseño responsivo |
| **jQuery Validation** | Validación del lado del cliente |
| **InMemory Repository Pattern** | Persistencia temporal de datos |
| **Visual Studio 2022** | IDE de desarrollo |
| **Git / GitHub** | Control de versiones y publicación del código |

---

## 📂 Estructura del proyecto

RegistroComunitario/
├── Controllers/
│ ├── HomeController.cs
│ └── ParticipantsController.cs
├── Models/
│ └── Participant.cs
├── Repositories/
│ ├── IParticipantRepository.cs
│ └── InMemoryParticipantRepository.cs
├── Views/
│ ├── Home/
│ │ ├── Index.cshtml
│ │ └── Privacy.cshtml
│ ├── Participants/
│ │ ├── Index.cshtml
│ │ └── Create.cshtml
│ └── Shared/
│ ├── _Layout.cshtml
│ ├── _ValidationScriptsPartial.cshtml
│ ├── _ViewStart.cshtml
│ └── _ViewImports.cshtml
├── wwwroot/
│ ├── css/
│ ├── js/
│ └── lib/
├── Program.cs
└── README.md

yaml
Copiar código

---

## ⚙️ Instalación y ejecución

### 1️⃣ Clonar el repositorio
```bash
git clone https://github.com/<tu_usuario>/RegistroComunitario.git
cd RegistroComunitario
2️⃣ Restaurar dependencias
bash
Copiar código
dotnet restore
3️⃣ Ejecutar el proyecto
bash
Copiar código
dotnet run
Luego abre tu navegador y visita:

arduino
Copiar código
https://localhost:5037/
🧠 Funcionamiento del sistema
El usuario ingresa a la página principal.

Puede registrar un nuevo participante o ver la lista existente.

El controlador valida los datos y los envía al repositorio en memoria.

Los datos se muestran en la vista de listado (Index.cshtml).

El flujo completo sigue el patrón Modelo–Vista–Controlador (MVC).


📦 Arquitectura
Capa	Responsabilidad
Model	Define la entidad Participant y sus validaciones.
Repository	Maneja la persistencia en memoria (CRUD básico).
Controller	Coordina la lógica entre modelo y vistas.
View (Razor)	Renderiza las páginas y muestra la información al usuario.

📚 Buenas prácticas aplicadas
Patrón Repository para desacoplar la lógica de acceso a datos.

Inyección de dependencias (AddSingleton) en Program.cs.

Validaciones con DataAnnotations + jQuery Unobtrusive Validation.

Uso de Tag Helpers (asp-for, asp-controller, asp-action) para vistas limpias.

Mensajes temporales (TempData) para confirmar operaciones exitosas.

Diseño responsivo con Bootstrap.

📖 Créditos
Desarrollado por: Jervis Calvo
📅 Año: 2025
🎓 Materia: Programación 3 – Práctica Semana 7
🏫 Institución: UCA

🧩 Mejoras futuras
Persistencia en base de datos SQL Server con Entity Framework Core.

Filtros de búsqueda y ordenamiento.

Autenticación básica de usuarios.

API REST complementaria para consumo móvil.

Dashboard de estadísticas (gráficos por género, edad, etc.).

🪶 Licencia
Este proyecto fue creado con fines educativos y puede ser reutilizado libremente con atribución.
MIT License © 2025 Jervis Calvo

yaml
Copiar código

---

## 💡 Recomendaciones

1. Crea una carpeta `docs/screenshots` y guarda allí tus capturas para que se muestren en GitHub.  
2. Si usas el diagrama que hicimos en Diagrams.net, exporta como PNG y colócalo en `docs/diagramas/flujo-registro.png`.  
3. Actualiza la URL de tu repositorio en el comando de clonación.

---

¿Quieres que el README incluya también un **diagrama de arquitectura MVC** (en imagen o texto Mermaid) para mostrar cómo se comunican el modelo, vista y controlador?  
Podemos añadirlo justo debajo del apartado *Arquitectura*.
