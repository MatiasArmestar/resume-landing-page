namespace resume_landing_page.Services;

public class TranslationService
{
    private readonly Dictionary<string, Dictionary<string, string>> _translations =
        new()
        {
            ["es"] = new()
            {
                ["nav.presentation"] = "Presentación",
                ["nav.skills"] = "Habilidades",
                ["nav.certifications"] = "Certificaciones",
                
                ["presentation.description"] = "Soy estudiante del 8vo ciclo de la carrera de Ingeniería de\r\n\t\t\t\t\tSoftware en la Universidad Peruana de Ciencias Aplicadas,\r\n\t\t\t\t\tcon sólida habilidad en planificación de proyectos de\r\n\t\t\t\t\tsoftware mediante metodología Scrum, motivación por el\r\n\t\t\t\t\tdesarrollo estructurado y limpio de código e interasado en\r\n\t\t\t\t\tel entorno .NET.",
                
                ["skills.title"] = "Habilidades",
                ["skills.languages"] = "Lenguajes y Frameworks",
                ["skills.tools"] = "Herramientas y Metodologías",

                ["skills.aspnetcore"] = "Orientado al desarrollo web y APIs REST usando C#.",
                ["skills.xunit"] = "Framework de .NET para crear y ejecutar pruebas unitarias y de integración.",
                ["skills.blazor"] = "Permite el desarrollo de interfaces web usando C#.",
                ["skills.springboot"] = "Desarrollo de aplicaciones web y APIs REST usando Java.",
                ["skills.nodejs"] = "Entorno de ejecución de JavaScript para desarrollo backend.",
                ["skills.pandas"] = "Librería de Python para la limpieza y transformación de datos.",

                ["skills.github"] = "Plataforma de alojamiento de repositorios y gestión de versiones.",
                ["skills.microsoftsqlserver"] = "Gestor de bases de datos relacionales.",
                ["skills.excel"] = "Herramienta para gestionar datos mediante hojas de cálculo.",
                ["skills.powerbi"] = "Plataforma para transformar datos en informes y dashboards.",
                ["skills.scrum"] = "Enfoque basado en Agile que organiza el desarrollo mediante Sprints.",
                ["skills.uipath"] = "Plataforma RPA para automatizar tareas y procesos repetitivos.",

                ["certifications.title"] = "Certificaciones",
                ["certifications.toefl"] = "TOEFL ITP (B2)",
                ["certifications.toefl.issue"] = "Junio, 2026",
                ["certifications.cybersecurity"] = "Ciberseguridad de Google",
                ["certifications.cybersecurity.issue"] = "Septiembre, 2025" ,
                ["certifications.english"] = "ICPNA - Programa Avanzado de Inglés",
                ["certifications.english.issue"] = "Mayo, 2021"
            },

            ["en"] = new()
            {
                ["nav.presentation"] = "Presentation",
                ["nav.skills"] = "Skills",
                ["nav.certifications"] = "Certifications",
                
                ["presentation.description"] = "I am an eighth-semester Software Engineering student at the \r\n\t\t\t\t\tPeruvian University of Applied Sciences (UPC), with strong \r\n\t\t\t\t\tskills in software project planning using the Scrum methodology, \r\n\t\t\t\t\ta commitment to structured and clean code development, and an \r\n\t\t\t\t\tinterest in the .NET environment.",
                
                ["skills.title"] = "Skills",
                ["skills.languages"] = "Languages and Frameworks",
                ["skills.tools"] = "Tools and Methodologies",

                ["skills.aspnetcore"] = "Focused on web development and REST APIs using C#.",
                ["skills.xunit"] = ".NET framework to create and execute unit and integration tests.",
                ["skills.blazor"] = "Enables the development of web interfaces using C#.",
                ["skills.springboot"] = "Development of web applications and REST APIs using Java.",
                ["skills.nodejs"] = "JavaScript runtime environment for backend development.",
                ["skills.pandas"] = "Python library for data cleaning and transformation.",

                ["skills.github"] = "Repository hosting and version control platform.",
                ["skills.microsoftsqlserver"] = "Relational database manager.",
                ["skills.excel"] = "Tool for managing data using spreadsheets.",
                ["skills.powerbi"] = "Platform for transforming data into reports and dashboards.",
                ["skills.scrum"] = "Agile-based approach that organizes development through Sprints.",
                ["skills.uipath"] = "RPA platform for automating repetitive tasks and processes.",
                
                ["certifications.title"] = "Certifications",
                ["certifications.toefl"] = "TOEFL ITP (B2)",
                ["certifications.toefl.issue"] = "June, 2026",
                ["certifications.cybersecurity"] = "Google Cybersecurity",
                ["certifications.cybersecurity.issue"] = "September, 2025",
                ["certifications.english"] = "ICPNA - Advanced Program of English",
                ["certifications.english.issue"] = "May, 2021"
            }
        };

    public string Get(string language, string key)
    {
        if (_translations.TryGetValue(language, out var lang) &&
            lang.TryGetValue(key, out var value))
        {
            return value;
        }

        return key;
    }
}