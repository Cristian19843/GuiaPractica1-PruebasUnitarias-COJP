# Guía Práctica 1: Pruebas Unitarias con MSTest y xUnit

**Estudiante:** Gerber Alexis Gómez Hidalgo  
**Iniciales de Solución:** GAGH  
**Entorno de desarrollo:** Visual Studio 2022 / .NET SDK  
**Herramientas de pruebas:** MSTest v2/v3 y xUnit  
**Gestión y Seguimiento:** Git / GitHub / Azure DevOps  

---

## 📌 Estructura de la Solución (`GAGH.sln`)

La solución contiene dos módulos principales con sus respectivos proyectos de pruebas unitarias:

```text
GAGH.sln
│
├── 📁 GAGH.Temperatura/                  # Ejercicio 1: Biblioteca de clases para conversión de temperaturas
│   └── TemperatureConverter.cs
├── 📁 GAGH.Temperatura.UnitTestMSTest/   # Proyecto de pruebas unitarias con MSTest
│   └── TemperatureConverterTests.cs
│
├── 📁 GAGH.Cadenas/                      # Ejercicio 2: Biblioteca de clases para manipulación de cadenas
│   └── StringManipulator.cs
└── 📁 GAGH.Cadenas.UnitTestAppxUnit/     # Proyecto de pruebas unitarias con xUnit
    └── StringManipulatorTests.cs
```

---

## 🛠️ Ejercicios Implementados

### 1. Convertidor de Temperatura (`GAGH.Temperatura`)
- **Framework de pruebas:** MSTest
- **Clase:** `TemperatureConverter`
- **Métodos implementados:**
  - `CelsiusToFahrenheit(double celsius)`: Convierte grados Celsius a Fahrenheit ($F = C \times \frac{9}{5} + 32$).
  - `FahrenheitToCelsius(double fahrenheit)`: Convierte grados Fahrenheit a Celsius ($C = (F - 32) \times \frac{5}{9}$).
- **Pruebas Unitarias:**
  - Casos normales (ebullición, congelación, cero absoluto, temperatura corporal).
  - Casos con valores negativos y decimales.
  - Validación con aserciones `Assert.AreEqual`.

### 2. Manipulador de Cadenas (`GAGH.Cadenas`)
- **Framework de pruebas:** xUnit
- **Clase:** `StringManipulator`
- **Métodos implementados:**
  - `ReverseString(string input)`: Invierte el contenido de la cadena de texto proporcionada.
  - `RemoveSpaces(string input)`: Elimina todos los espacios en blanco de la cadena.
- **Pruebas Unitarias:**
  - Pruebas unitarias directas (`[Fact]`).
  - Pruebas parametrizadas (`[Theory]` e `[InlineData]`).
  - Validación de excepciones para valores `null` (`Assert.Throws<ArgumentNullException>`).
  - Validación de cadenas vacías y solo con espacios.

---

## 🚀 Ejecución de Pruebas

Para compilar y ejecutar todas las pruebas unitarias desde la terminal:

```bash
# Compilar la solución
dotnet build GAGH.sln

# Ejecutar todas las pruebas unitarias
dotnet test GAGH.sln
```
