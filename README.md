# 🧍‍♂️ Registro Comunitario – Práctica Semana 7

Aplicación web desarrollada en **ASP.NET Core MVC (.NET 8)** como práctica académica de la materia **Programación 3**.  
Permite **registrar participantes**, almacenarlos **en memoria**, y mostrarlos en una tabla dinámica con validaciones y diseño profesional basado en **Bootstrap 5**.

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


---

## ⚙️ Instalación y ejecución

### 1️⃣ Clonar el repositorio
```bash
git clone https://github.com/<tu_usuario>/RegistroComunitario.git
cd RegistroComunitario

🧠 Funcionamiento del sistema

El usuario ingresa a la página principal.

Puede registrar un nuevo participante o ver la lista existente.

El controlador valida los datos y los envía al repositorio en memoria.

Los datos se muestran en la vista de listado (Index.cshtml).

El flujo completo sigue el patrón Modelo–Vista–Controlador (MVC).
