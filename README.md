# Guía Práctica 1: Pruebas Unitarias con MSTest y xUnit

**Estudiante:** Cristian Omar Jordan Perez  
**Iniciales de Solución:** COJP  
**Docente:** Gerber Alexis Gómez Hidalgo  
**Entorno de desarrollo:** Visual Studio 2022 / .NET SDK  
**Herramientas de pruebas:** MSTest v2/v3 y xUnit  
**Gestión y Seguimiento:** Git / GitHub / Azure DevOps  

---

## 📌 Estructura de la Solución (`COJP.sln`)

La solución contiene los dos ejercicios requeridos en la guía con sus correspondientes bibliotecas de clases y proyectos de pruebas unitarias:

```text
COJP.sln
│
├── 📁 COJP.Temperatura/                  # Ejercicio 1: Biblioteca de clases para conversión de temperaturas
│   ├── TemperatureConverter.cs
│   └── COJP.Temperatura.csproj
│
├── 📁 COJP.Temperatura.UnitTestMSTest/   # Ejercicio 1: Pruebas unitarias con MSTest
│   ├── TemperatureConverterTests.cs
│   └── COJP.Temperatura.UnitTestMSTest.csproj
│
├── 📁 COJP.Cadenas/                      # Ejercicio 2: Biblioteca de clases para manipulación de cadenas
│   ├── StringManipulator.cs
│   └── COJP.Cadenas.csproj
│
└── 📁 COJP.Cadenas.UnitTestAppxUnit/     # Ejercicio 2: Pruebas unitarias con xUnit
    ├── StringManipulatorTests.cs
    └── COJP.Cadenas.UnitTestAppxUnit.csproj
```

---

## 🛠️ Ejercicios Implementados

### 1. Convertidor de Temperatura (`COJP.Temperatura`)
- **Framework de pruebas:** MSTest
- **Clase:** `TemperatureConverter`
- **Métodos implementados:**
  - `CelsiusToFahrenheit(double celsius)`: Convierte grados Celsius a Fahrenheit ($F = C \times \frac{9}{5} + 32$).
  - `FahrenheitToCelsius(double fahrenheit)`: Convierte grados Fahrenheit a Celsius ($C = (F - 32) \times \frac{5}{9}$).
- **Pruebas Unitarias (MSTest):**
  - Validación de puntos clave (congelación $0^\circ C \to 32^\circ F$, ebullición $100^\circ C \to 212^\circ F$, coincidencia $-40^\circ C \to -40^\circ F$).
  - Conversión de temperaturas corporales y decimales con delta de tolerancia.
  - Conversión inversa exacta de Fahrenheit a Celsius.
  - Aserciones con `Assert.AreEqual`.

### 2. Manipulador de Cadenas (`COJP.Cadenas`)
- **Framework de pruebas:** xUnit
- **Clase:** `StringManipulator`
- **Métodos implementados:**
  - `ReverseString(string input)`: Invierte la cadena de caracteres recibida. Valida entradas nulas.
  - `RemoveSpaces(string input)`: Elimina todos los espacios en blanco presentes en la cadena. Valida entradas nulas.
- **Pruebas Unitarias (xUnit):**
  - Pruebas unitarias atómicas (`[Fact]`).
  - Pruebas parametrizadas (`[Theory]` con `[InlineData]`).
  - Validación de excepciones ante entradas nulas (`Assert.Throws<ArgumentNullException>`).
  - Pruebas con cadenas vacías, espacios intermedios y espacios múltiples.
  - Aserciones con `Assert.Equal`.

---

## 🚀 Ejecución de Pruebas

Para compilar la solución y ejecutar todas las pruebas unitarias:

```bash
# Compilar la solución
dotnet build COJP.sln

# Ejecutar las pruebas unitarias
dotnet test COJP.sln
```
