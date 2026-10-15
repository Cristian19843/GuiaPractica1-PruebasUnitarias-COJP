# Documentación de Casos de Prueba en Azure DevOps
## Guía Práctica 1: Pruebas Unitarias con MSTest y xUnit

**Estudiante:** Cristian Omar Jordan Perez  
**Iniciales:** COJP  
**Solución:** `COJP.sln`  
**Docente:** Gerber Alexis Gómez Hidalgo  
**Repositorio GitHub:** [https://github.com/Cristian19843/GuiaPractica1-PruebasUnitarias-COJP](https://github.com/Cristian19843/GuiaPractica1-PruebasUnitarias-COJP)  
**Azure DevOps Project:** [https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/)  

---

## 📋 Resumen de Registro en Azure DevOps (Work Items de Tipo Test Case)

Todos los casos de prueba han sido registrados y documentados exitosamente en la plataforma Azure DevOps dentro del proyecto **Guia1-PruebasUnitarias-Iniciales** con los identificadores oficiales:

| ID Azure | Código Caso | Suite / Ejercicio | Título del Caso de Prueba | Framework | Estado |
| :---: | :---: | :---: | :--- | :---: | :---: |
| [**#418**](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/_workitems/edit/418) | CP01 | Ejercicio 1 (Temperatura) | Convertir Celsius a Fahrenheit en punto de congelación ($0^\circ C \to 32^\circ F$) | MSTest | Design / Ready |
| [**#419**](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/_workitems/edit/419) | CP02 | Ejercicio 1 (Temperatura) | Convertir Celsius a Fahrenheit en punto de ebullición ($100^\circ C \to 212^\circ F$) | MSTest | Design / Ready |
| [**#420**](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/_workitems/edit/420) | CP03 | Ejercicio 1 (Temperatura) | Convertir Celsius a Fahrenheit con temperatura negativa ($-40^\circ C \to -40^\circ F$) | MSTest | Design / Ready |
| [**#421**](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/_workitems/edit/421) | CP04 | Ejercicio 1 (Temperatura) | Convertir Celsius a Fahrenheit con temperatura corporal ($37^\circ C \to 98.6^\circ F$) | MSTest | Design / Ready |
| [**#422**](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/_workitems/edit/422) | CP05 | Ejercicio 1 (Temperatura) | Convertir Fahrenheit a Celsius en punto de congelación ($32^\circ F \to 0^\circ C$) | MSTest | Design / Ready |
| [**#423**](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/_workitems/edit/423) | CP06 | Ejercicio 1 (Temperatura) | Convertir Fahrenheit a Celsius en punto de ebullición ($212^\circ F \to 100^\circ C$) | MSTest | Design / Ready |
| [**#424**](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/_workitems/edit/424) | CP07 | Ejercicio 1 (Temperatura) | Convertir Fahrenheit a Celsius con temperatura negativa ($-40^\circ F \to -40^\circ C$) | MSTest | Design / Ready |
| [**#425**](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/_workitems/edit/425) | CP08 | Ejercicio 1 (Temperatura) | Convertir Fahrenheit a Celsius con temperatura corporal ($98.6^\circ F \to 37^\circ C$) | MSTest | Design / Ready |
| [**#426**](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/_workitems/edit/426) | CP09 | Ejercicio 2 (Cadenas) | Invertir texto estándar válido ("Hola Mundo" $\to$ "odnuM aloH") | xUnit | Design / Ready |
| [**#427**](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/_workitems/edit/427) | CP10 | Ejercicio 2 (Cadenas) | Invertir palabra palíndroma ("reconocer" $\to$ "reconocer") | xUnit | Design / Ready |
| [**#428**](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/_workitems/edit/428) | CP11 | Ejercicio 2 (Cadenas) | Invertir cadena vacía (`""` $\to$ `""`) | xUnit | Design / Ready |
| [**#429**](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/_workitems/edit/429) | CP12 | Ejercicio 2 (Cadenas) | Validar excepción ArgumentNullException al invertir cadena nula (null) | xUnit | Design / Ready |
| [**#430**](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/_workitems/edit/430) | CP13 | Ejercicio 2 (Cadenas) | Eliminar espacios en frase con separación estándar ("Hola Mundo" $\to$ "HolaMundo") | xUnit | Design / Ready |
| [**#431**](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/_workitems/edit/431) | CP14 | Ejercicio 2 (Cadenas) | Eliminar espacios múltiples intermedios y en extremos | xUnit | Design / Ready |
| [**#432**](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/_workitems/edit/432) | CP15 | Ejercicio 2 (Cadenas) | Eliminar espacios en cadena sin espacios ("CSharp" $\to$ "CSharp") | xUnit | Design / Ready |
| [**#433**](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/_workitems/edit/433) | CP16 | Ejercicio 2 (Cadenas) | Validar excepción ArgumentNullException al eliminar espacios de cadena nula | xUnit | Design / Ready |
| [**#434**](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/_workitems/edit/434) | CP17 | Ejercicio 2 (Cadenas) | Prueba parametrizada xUnit (Theory) para inversión de múltiples cadenas | xUnit (Theory) | Design / Ready |
| [**#435**](https://dev.azure.com/arpineda15190/Guia1-PruebasUnitarias-Iniciales/_workitems/edit/435) | CP18 | Ejercicio 2 (Cadenas) | Prueba parametrizada xUnit (Theory) para eliminación de espacios en múltiples formatos | xUnit (Theory) | Design / Ready |

---

## 🌡️ Detalle Ejercicio 1: Convertidor de Temperatura (`COJP.Temperatura`)
**Proyecto:** `COJP.Temperatura`  
**Proyecto de Pruebas:** `COJP.Temperatura.UnitTestMSTest`  
**Clase:** `TemperatureConverter`  
**Framework:** MSTest v3  

### Work Item #418 (CP01)
- **Título:** COJP - CP01 - Convertir Celsius a Fahrenheit en punto de congelación (0°C -> 32°F)
- **Etiquetas:** `MSTest; Temperatura`
- **Prioridad:** 1
- **Método de Prueba:** `CelsiusToFahrenheit_FreezingPoint_Returns32()`
- **Pasos:**
  1. *Action:* Arrange: Instanciar TemperatureConverter y definir celsius = 0.0, esperado = 32.0  
     *Expected:* Instancia creada y variables inicializadas.
  2. *Action:* Act: Ejecutar resultado = converter.CelsiusToFahrenheit(celsius)  
     *Expected:* Se obtiene el cálculo de conversión (32.0).
  3. *Action:* Assert: Validar con Assert.AreEqual(esperado, resultado, 0.001)  
     *Expected:* Aserción exitosa (resultado == 32.0).

### Work Item #419 (CP02)
- **Título:** COJP - CP02 - Convertir Celsius a Fahrenheit en punto de ebullición (100°C -> 212°F)
- **Etiquetas:** `MSTest; Temperatura`
- **Prioridad:** 1
- **Método de Prueba:** `CelsiusToFahrenheit_BoilingPoint_Returns212()`
- **Pasos:**
  1. *Action:* Arrange: Instanciar TemperatureConverter y definir celsius = 100.0, esperado = 212.0  
     *Expected:* Instancia creada y variables inicializadas.
  2. *Action:* Act: Ejecutar resultado = converter.CelsiusToFahrenheit(celsius)  
     *Expected:* Se obtiene el cálculo de conversión (212.0).
  3. *Action:* Assert: Validar con Assert.AreEqual(esperado, resultado, 0.001)  
     *Expected:* Aserción exitosa (resultado == 212.0).

### Work Item #420 (CP03)
- **Título:** COJP - CP03 - Convertir Celsius a Fahrenheit con temperatura negativa (-40°C -> -40°F)
- **Etiquetas:** `MSTest; Temperatura`
- **Prioridad:** 2
- **Método de Prueba:** `CelsiusToFahrenheit_EqualScalePoint_ReturnsMinus40()`
- **Pasos:**
  1. *Action:* Arrange: Instanciar TemperatureConverter y definir celsius = -40.0, esperado = -40.0  
     *Expected:* Instancia creada y variables inicializadas.
  2. *Action:* Act: Ejecutar resultado = converter.CelsiusToFahrenheit(celsius)  
     *Expected:* Se obtiene el cálculo de conversión (-40.0).
  3. *Action:* Assert: Validar con Assert.AreEqual(esperado, resultado, 0.001)  
     *Expected:* Aserción exitosa (resultado == -40.0).

### Work Item #421 (CP04)
- **Título:** COJP - CP04 - Convertir Celsius a Fahrenheit con temperatura corporal (37°C -> 98.6°F)
- **Etiquetas:** `MSTest; Temperatura`
- **Prioridad:** 2
- **Método de Prueba:** `CelsiusToFahrenheit_BodyTemperature_Returns98Point6()`
- **Pasos:**
  1. *Action:* Arrange: Instanciar TemperatureConverter y definir celsius = 37.0, esperado = 98.6  
     *Expected:* Instancia creada y variables inicializadas.
  2. *Action:* Act: Ejecutar resultado = converter.CelsiusToFahrenheit(celsius)  
     *Expected:* Se obtiene el cálculo de conversión (98.6).
  3. *Action:* Assert: Validar con Assert.AreEqual(esperado, resultado, 0.001)  
     *Expected:* Aserción exitosa (resultado == 98.6).

### Work Item #422 (CP05)
- **Título:** COJP - CP05 - Convertir Fahrenheit a Celsius en punto de congelación (32°F -> 0°C)
- **Etiquetas:** `MSTest; Temperatura`
- **Prioridad:** 1
- **Método de Prueba:** `FahrenheitToCelsius_FreezingPoint_Returns0()`
- **Pasos:**
  1. *Action:* Arrange: Instanciar TemperatureConverter y definir fahrenheit = 32.0, esperado = 0.0  
     *Expected:* Instancia creada y variables inicializadas.
  2. *Action:* Act: Ejecutar resultado = converter.FahrenheitToCelsius(fahrenheit)  
     *Expected:* Se obtiene el cálculo de conversión (0.0).
  3. *Action:* Assert: Validar con Assert.AreEqual(esperado, resultado, 0.001)  
     *Expected:* Aserción exitosa (resultado == 0.0).

### Work Item #423 (CP06)
- **Título:** COJP - CP06 - Convertir Fahrenheit a Celsius en punto de ebullición (212°F -> 100°C)
- **Etiquetas:** `MSTest; Temperatura`
- **Prioridad:** 1
- **Método de Prueba:** `FahrenheitToCelsius_BoilingPoint_Returns100()`
- **Pasos:**
  1. *Action:* Arrange: Instanciar TemperatureConverter y definir fahrenheit = 212.0, esperado = 100.0  
     *Expected:* Instancia creada y variables inicializadas.
  2. *Action:* Act: Ejecutar resultado = converter.FahrenheitToCelsius(fahrenheit)  
     *Expected:* Se obtiene el cálculo de conversión (100.0).
  3. *Action:* Assert: Validar con Assert.AreEqual(esperado, resultado, 0.001)  
     *Expected:* Aserción exitosa (resultado == 100.0).

### Work Item #424 (CP07)
- **Título:** COJP - CP07 - Convertir Fahrenheit a Celsius con temperatura negativa (-40°F -> -40°C)
- **Etiquetas:** `MSTest; Temperatura`
- **Prioridad:** 2
- **Método de Prueba:** `FahrenheitToCelsius_EqualScalePoint_ReturnsMinus40()`
- **Pasos:**
  1. *Action:* Arrange: Instanciar TemperatureConverter y definir fahrenheit = -40.0, esperado = -40.0  
     *Expected:* Instancia creada y variables inicializadas.
  2. *Action:* Act: Ejecutar resultado = converter.FahrenheitToCelsius(fahrenheit)  
     *Expected:* Se obtiene el cálculo de conversión (-40.0).
  3. *Action:* Assert: Validar con Assert.AreEqual(esperado, resultado, 0.001)  
     *Expected:* Aserción exitosa (resultado == -40.0).

### Work Item #425 (CP08)
- **Título:** COJP - CP08 - Convertir Fahrenheit a Celsius con temperatura corporal (98.6°F -> 37°C)
- **Etiquetas:** `MSTest; Temperatura`
- **Prioridad:** 2
- **Método de Prueba:** `FahrenheitToCelsius_BodyTemperature_Returns37()`
- **Pasos:**
  1. *Action:* Arrange: Instanciar TemperatureConverter y definir fahrenheit = 98.6, esperado = 37.0  
     *Expected:* Instancia creada y variables inicializadas.
  2. *Action:* Act: Ejecutar resultado = converter.FahrenheitToCelsius(fahrenheit)  
     *Expected:* Se obtiene el cálculo de conversión (37.0).
  3. *Action:* Assert: Validar con Assert.AreEqual(esperado, resultado, 0.001)  
     *Expected:* Aserción exitosa (resultado == 37.0).

---

## 🔤 Detalle Ejercicio 2: Manipulación de Cadenas (`COJP.Cadenas`)
**Proyecto:** `COJP.Cadenas`  
**Proyecto de Pruebas:** `COJP.Cadenas.UnitTestAppxUnit`  
**Clase:** `StringManipulator`  
**Framework:** xUnit v2  

### Work Item #426 (CP09)
- **Título:** COJP - CP09 - Invertir texto estándar válido ('Hola Mundo' -> 'odnuM aloH')
- **Etiquetas:** `Cadenas; xUnit`
- **Prioridad:** 1
- **Método de Prueba:** `ReverseString_PhraseWithSpaces_ReturnsReversedPhrase()`

### Work Item #427 (CP10)
- **Título:** COJP - CP10 - Invertir palabra palíndroma ('reconocer' -> 'reconocer')
- **Etiquetas:** `Cadenas; xUnit`
- **Prioridad:** 2
- **Método de Prueba:** `ReverseString_Palindrome_ReturnsSameWord()`

### Work Item #428 (CP11)
- **Título:** COJP - CP11 - Invertir cadena vacía ('' -> '')
- **Etiquetas:** `Cadenas; xUnit`
- **Prioridad:** 2
- **Método de Prueba:** `ReverseString_EmptyString_ReturnsEmptyString()`

### Work Item #429 (CP12)
- **Título:** COJP - CP12 - Validar excepción ArgumentNullException al invertir cadena nula (null)
- **Etiquetas:** `Cadenas; xUnit`
- **Prioridad:** 1
- **Método de Prueba:** `ReverseString_NullInput_ThrowsArgumentNullException()`

### Work Item #430 (CP13)
- **Título:** COJP - CP13 - Eliminar espacios en frase con separación estándar ('Hola Mundo' -> 'HolaMundo')
- **Etiquetas:** `Cadenas; xUnit`
- **Prioridad:** 1
- **Método de Prueba:** `RemoveSpaces_SingleSpaceBetweenWords_ReturnsCombinedString()`

### Work Item #431 (CP14)
- **Título:** COJP - CP14 - Eliminar espacios múltiples intermedios y en los extremos
- **Etiquetas:** `Cadenas; xUnit`
- **Prioridad:** 1
- **Método de Prueba:** `RemoveSpaces_MultipleSpaces_ReturnsStringWithoutSpaces()`

### Work Item #432 (CP15)
- **Título:** COJP - CP15 - Eliminar espacios en cadena sin espacios ('CSharp' -> 'CSharp')
- **Etiquetas:** `Cadenas; xUnit`
- **Prioridad:** 2
- **Método de Prueba:** `RemoveSpaces_StringWithoutSpaces_ReturnsOriginalString()`

### Work Item #433 (CP16)
- **Título:** COJP - CP16 - Validar excepción ArgumentNullException al eliminar espacios de cadena nula (null)
- **Etiquetas:** `Cadenas; xUnit`
- **Prioridad:** 1
- **Método de Prueba:** `RemoveSpaces_NullInput_ThrowsArgumentNullException()`

### Work Item #434 (CP17)
- **Título:** COJP - CP17 - Prueba parametrizada xUnit (Theory) para inversión de múltiples cadenas
- **Etiquetas:** `Cadenas; Theory; xUnit`
- **Prioridad:** 1
- **Método de Prueba:** `ReverseString_Theory_ReturnsExpected(input, expected)`

### Work Item #435 (CP18)
- **Título:** COJP - CP18 - Prueba parametrizada xUnit (Theory) para eliminación de espacios en múltiples formatos
- **Etiquetas:** `Cadenas; Theory; xUnit`
- **Prioridad:** 1
- **Método de Prueba:** `RemoveSpaces_Theory_ReturnsExpected(input, expected)`
