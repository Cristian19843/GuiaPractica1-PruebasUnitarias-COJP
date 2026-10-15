# Documentación de Casos de Prueba en Azure DevOps
## Guía Práctica 1: Pruebas Unitarias con MSTest y xUnit

**Estudiante:** Cristian Omar Jordan Perez  
**Iniciales:** COJP  
**Solución:** `COJP.sln`  
**Fecha:** 15 de Octubre de 2026  
**Docente:** Gerber Alexis Gómez Hidalgo  

---

## 📋 Estructura del Plan de Pruebas en Azure DevOps

- **Organización:** `https://dev.azure.com/{Tu-Usuario}/`
- **Proyecto:** `GuiaPractica1-PruebasUnitarias-COJP`
- **Test Plan:** `Plan de Pruebas Unitarias - COJP`
  - 📁 **Test Suite 1 (Requisito 1):** `COJP.Temperatura - MSTest`
  - 📁 **Test Suite 2 (Requisito 2):** `COJP.Cadenas - xUnit`

---

## 🌡️ Test Suite 1: Convertidor de Temperatura (`COJP.Temperatura`)
**Framework:** MSTest v3  
**Clase bajo prueba:** `COJP.Temperatura.TemperatureConverter`  
**Proyecto de prueba:** `COJP.Temperatura.UnitTestMSTest`

### Caso de Prueba CP-TEMP-01
- **Título:** Conversión de Celsius a Fahrenheit en punto de congelación ($0^\circ C \to 32^\circ F$)
- **Prioridad:** 1 (Alta)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `TemperatureConverterTests.CelsiusToFahrenheit_FreezingPoint_Returns32`
- **Precondiciones:** Instancia de `TemperatureConverter` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Definir valor de entrada en grados Celsius: `0.0`. | Entrada configurada correctamente. |
  | 2 | Ejecutar método `CelsiusToFahrenheit(0.0)`. | El método calcula $(0 \times 9/5) + 32$. |
  | 3 | Evaluar aserción `Assert.AreEqual(32.0, actual, 0.001)`. | La aserción es exitosa. Retorna `32.0°F`. |
- **Resultado:** ✅ Superado (Passed)

### Caso de Prueba CP-TEMP-02
- **Título:** Conversión de Celsius a Fahrenheit en punto de ebullición ($100^\circ C \to 212^\circ F$)
- **Prioridad:** 1 (Alta)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `TemperatureConverterTests.CelsiusToFahrenheit_BoilingPoint_Returns212`
- **Precondiciones:** Instancia de `TemperatureConverter` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Definir valor de entrada en grados Celsius: `100.0`. | Entrada configurada correctamente. |
  | 2 | Ejecutar método `CelsiusToFahrenheit(100.0)`. | El método calcula $(100 \times 9/5) + 32$. |
  | 3 | Evaluar aserción `Assert.AreEqual(212.0, actual, 0.001)`. | La aserción es exitosa. Retorna `212.0°F`. |
- **Resultado:** ✅ Superado (Passed)

### Caso de Prueba CP-TEMP-03
- **Título:** Conversión en punto de coincidencia de escalas Celsius y Fahrenheit ($-40^\circ C \to -40^\circ F$)
- **Prioridad:** 2 (Media)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `TemperatureConverterTests.CelsiusToFahrenheit_EqualScalePoint_ReturnsMinus40`
- **Precondiciones:** Instancia de `TemperatureConverter` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Definir valor de entrada en grados Celsius: `-40.0`. | Entrada configurada correctamente. |
  | 2 | Ejecutar método `CelsiusToFahrenheit(-40.0)`. | El método calcula $(-40 \times 9/5) + 32$. |
  | 3 | Evaluar aserción `Assert.AreEqual(-40.0, actual, 0.001)`. | La aserción es exitosa. Retorna `-40.0°F`. |
- **Resultado:** ✅ Superado (Passed)

### Caso de Prueba CP-TEMP-04
- **Título:** Conversión de Celsius a Fahrenheit en temperatura ambiente ($25^\circ C \to 77^\circ F$)
- **Prioridad:** 2 (Media)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `TemperatureConverterTests.CelsiusToFahrenheit_RoomTemperature_Returns77`
- **Precondiciones:** Instancia de `TemperatureConverter` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Definir valor de entrada en grados Celsius: `25.0`. | Entrada configurada correctamente. |
  | 2 | Ejecutar método `CelsiusToFahrenheit(25.0)`. | El método calcula $(25 \times 9/5) + 32$. |
  | 3 | Evaluar aserción `Assert.AreEqual(77.0, actual, 0.001)`. | La aserción es exitosa. Retorna `77.0°F`. |
- **Resultado:** ✅ Superado (Passed)

### Caso de Prueba CP-TEMP-05
- **Título:** Conversión de Celsius a Fahrenheit para temperatura corporal ($37^\circ C \to 98.6^\circ F$)
- **Prioridad:** 2 (Media)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `TemperatureConverterTests.CelsiusToFahrenheit_BodyTemperature_Returns98Point6`
- **Precondiciones:** Instancia de `TemperatureConverter` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Definir valor de entrada en grados Celsius: `37.0`. | Entrada configurada correctamente. |
  | 2 | Ejecutar método `CelsiusToFahrenheit(37.0)`. | El método calcula $(37 \times 9/5) + 32$. |
  | 3 | Evaluar aserción `Assert.AreEqual(98.6, actual, 0.001)`. | La aserción es exitosa. Retorna `98.6°F`. |
- **Resultado:** ✅ Superado (Passed)

### Caso de Prueba CP-TEMP-06
- **Título:** Conversión de Fahrenheit a Celsius en punto de congelación ($32^\circ F \to 0^\circ C$)
- **Prioridad:** 1 (Alta)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `TemperatureConverterTests.FahrenheitToCelsius_FreezingPoint_Returns0`
- **Precondiciones:** Instancia de `TemperatureConverter` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Definir valor de entrada en grados Fahrenheit: `32.0`. | Entrada configurada correctamente. |
  | 2 | Ejecutar método `FahrenheitToCelsius(32.0)`. | El método calcula $(32 - 32) \times 5/9$. |
  | 3 | Evaluar aserción `Assert.AreEqual(0.0, actual, 0.001)`. | La aserción es exitosa. Retorna `0.0°C`. |
- **Resultado:** ✅ Superado (Passed)

### Caso de Prueba CP-TEMP-07
- **Título:** Conversión de Fahrenheit a Celsius en punto de ebullición ($212^\circ F \to 100^\circ C$)
- **Prioridad:** 1 (Alta)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `TemperatureConverterTests.FahrenheitToCelsius_BoilingPoint_Returns100`
- **Precondiciones:** Instancia de `TemperatureConverter` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Definir valor de entrada en grados Fahrenheit: `212.0`. | Entrada configurada correctamente. |
  | 2 | Ejecutar método `FahrenheitToCelsius(212.0)`. | El método calcula $(212 - 32) \times 5/9$. |
  | 3 | Evaluar aserción `Assert.AreEqual(100.0, actual, 0.001)`. | La aserción es exitosa. Retorna `100.0°C`. |
- **Resultado:** ✅ Superado (Passed)

### Caso de Prueba CP-TEMP-08
- **Título:** Conversión de Fahrenheit a Celsius en escala negativa de coincidencia ($-40^\circ F \to -40^\circ C$)
- **Prioridad:** 2 (Media)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `TemperatureConverterTests.FahrenheitToCelsius_EqualScalePoint_ReturnsMinus40`
- **Precondiciones:** Instancia de `TemperatureConverter` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Definir valor de entrada en grados Fahrenheit: `-40.0`. | Entrada configurada correctamente. |
  | 2 | Ejecutar método `FahrenheitToCelsius(-40.0)`. | El método calcula $(-40 - 32) \times 5/9$. |
  | 3 | Evaluar aserción `Assert.AreEqual(-40.0, actual, 0.001)`. | La aserción es exitosa. Retorna `-40.0°C`. |
- **Resultado:** ✅ Superado (Passed)

### Caso de Prueba CP-TEMP-09
- **Título:** Conversión de Fahrenheit a Celsius en temperatura ambiente ($77^\circ F \to 25^\circ C$)
- **Prioridad:** 2 (Media)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `TemperatureConverterTests.FahrenheitToCelsius_RoomTemperature_Returns25`
- **Precondiciones:** Instancia de `TemperatureConverter` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Definir valor de entrada en grados Fahrenheit: `77.0`. | Entrada configurada correctamente. |
  | 2 | Ejecutar método `FahrenheitToCelsius(77.0)`. | El método calcula $(77 - 32) \times 5/9$. |
  | 3 | Evaluar aserción `Assert.AreEqual(25.0, actual, 0.001)`. | La aserción es exitosa. Retorna `25.0°C`. |
- **Resultado:** ✅ Superado (Passed)

### Caso de Prueba CP-TEMP-10
- **Título:** Conversión de Fahrenheit a Celsius para temperatura corporal ($98.6^\circ F \to 37^\circ C$)
- **Prioridad:** 2 (Media)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `TemperatureConverterTests.FahrenheitToCelsius_BodyTemperature_Returns37`
- **Precondiciones:** Instancia de `TemperatureConverter` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Definir valor de entrada en grados Fahrenheit: `98.6`. | Entrada configurada correctamente. |
  | 2 | Ejecutar método `FahrenheitToCelsius(98.6)`. | El método calcula $(98.6 - 32) \times 5/9$. |
  | 3 | Evaluar aserción `Assert.AreEqual(37.0, actual, 0.001)`. | La aserción es exitosa. Retorna `37.0°C`. |
- **Resultado:** ✅ Superado (Passed)

---

## 🔤 Test Suite 2: Manipulación de Cadenas (`COJP.Cadenas`)
**Framework:** xUnit v2  
**Clase bajo prueba:** `COJP.Cadenas.StringManipulator`  
**Proyecto de prueba:** `COJP.Cadenas.UnitTestAppxUnit`

### Caso de Prueba CP-CAD-01
- **Título:** Inversión de palabra simple sin espacios ("hola" $\to$ "aloh")
- **Prioridad:** 1 (Alta)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `StringManipulatorTests.ReverseString_SimpleWord_ReturnsReversed`
- **Precondiciones:** Instancia de `StringManipulator` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Definir cadena de entrada: `"hola"`. | Entrada configurada correctamente. |
  | 2 | Ejecutar método `ReverseString("hola")`. | Se invierte el arreglo de caracteres. |
  | 3 | Evaluar aserción `Assert.Equal("aloh", actual)`. | La aserción es exitosa. Retorna `"aloh"`. |
- **Resultado:** ✅ Superado (Passed)

### Caso de Prueba CP-CAD-02
- **Título:** Inversión de palabra palíndroma ("reconocer" $\to$ "reconocer")
- **Prioridad:** 2 (Media)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `StringManipulatorTests.ReverseString_Palindrome_ReturnsSameWord`
- **Precondiciones:** Instancia de `StringManipulator` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Definir cadena de entrada palíndroma: `"reconocer"`. | Entrada configurada correctamente. |
  | 2 | Ejecutar método `ReverseString("reconocer")`. | Los caracteres se invierten simétricamente. |
  | 3 | Evaluar aserción `Assert.Equal("reconocer", actual)`. | La aserción es exitosa. Retorna `"reconocer"`. |
- **Resultado:** ✅ Superado (Passed)

### Caso de Prueba CP-CAD-03
- **Título:** Inversión de frase con espacios intercalados ("Hola Mundo" $\to$ "odnuM aloH")
- **Prioridad:** 1 (Alta)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `StringManipulatorTests.ReverseString_PhraseWithSpaces_ReturnsReversedPhrase`
- **Precondiciones:** Instancia de `StringManipulator` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Definir cadena de entrada: `"Hola Mundo"`. | Entrada configurada correctamente. |
  | 2 | Ejecutar método `ReverseString("Hola Mundo")`. | Se invierte el orden respetando espacios. |
  | 3 | Evaluar aserción `Assert.Equal("odnuM aloH", actual)`. | La aserción es exitosa. Retorna `"odnuM aloH"`. |
- **Resultado:** ✅ Superado (Passed)

### Caso de Prueba CP-CAD-04
- **Título:** Manejo de cadena vacía en inversión (`""` $\to$ `""`)
- **Prioridad:** 2 (Media)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `StringManipulatorTests.ReverseString_EmptyString_ReturnsEmptyString`
- **Precondiciones:** Instancia de `StringManipulator` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Definir cadena de entrada vacía `string.Empty`. | Entrada configurada correctamente. |
  | 2 | Ejecutar método `ReverseString(string.Empty)`. | Detecta longitud 0 y retorna cadena vacía. |
  | 3 | Evaluar aserción `Assert.Equal(string.Empty, actual)`. | La aserción es exitosa. |
- **Resultado:** ✅ Superado (Passed)

### Caso de Prueba CP-CAD-05
- **Título:** Validación de excepción ante entrada nula en inversión (`null` $\to$ `ArgumentNullException`)
- **Prioridad:** 1 (Alta)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `StringManipulatorTests.ReverseString_NullInput_ThrowsArgumentNullException`
- **Precondiciones:** Instancia de `StringManipulator` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Pasar valor `null` al método `ReverseString`. | La invocación se ejecuta. |
  | 2 | Evaluar mediante `Assert.Throws<ArgumentNullException>`. | Se captura la excepción `ArgumentNullException`. |
- **Resultado:** ✅ Superado (Passed)

### Caso de Prueba CP-CAD-06
- **Título:** Eliminación de espacio único entre palabras ("Hola Mundo" $\to$ "HolaMundo")
- **Prioridad:** 1 (Alta)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `StringManipulatorTests.RemoveSpaces_SingleSpaceBetweenWords_ReturnsCombinedString`
- **Precondiciones:** Instancia de `StringManipulator` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Definir cadena de entrada: `"Hola Mundo"`. | Entrada configurada correctamente. |
  | 2 | Ejecutar método `RemoveSpaces("Hola Mundo")`. | Se remueven los espacios en blanco. |
  | 3 | Evaluar aserción `Assert.Equal("HolaMundo", actual)`. | La aserción es exitosa. Retorna `"HolaMundo"`. |
- **Resultado:** ✅ Superado (Passed)

### Caso de Prueba CP-CAD-07
- **Título:** Eliminación de múltiples espacios consecutivos y en bordes
- **Prioridad:** 1 (Alta)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `StringManipulatorTests.RemoveSpaces_MultipleSpaces_ReturnsStringWithoutSpaces`
- **Precondiciones:** Instancia de `StringManipulator` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Entrada: `"  Pruebas   unitarias   con   xUnit  "`. | Entrada configurada correctamente. |
  | 2 | Ejecutar método `RemoveSpaces(...)`. | Se eliminan todos los espacios. |
  | 3 | Evaluar aserción `Assert.Equal("PruebasunitariasconxUnit", actual)`. | La aserción es exitosa. |
- **Resultado:** ✅ Superado (Passed)

### Caso de Prueba CP-CAD-08
- **Título:** Preservación de cadena que no contiene espacios ("CSharp" $\to$ "CSharp")
- **Prioridad:** 2 (Media)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `StringManipulatorTests.RemoveSpaces_StringWithoutSpaces_ReturnsOriginalString`
- **Precondiciones:** Instancia de `StringManipulator` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Definir entrada sin espacios: `"CSharp"`. | Entrada configurada correctamente. |
  | 2 | Ejecutar método `RemoveSpaces("CSharp")`. | No sufre alteraciones. |
  | 3 | Evaluar aserción `Assert.Equal("CSharp", actual)`. | La aserción es exitosa. |
- **Resultado:** ✅ Superado (Passed)

### Caso de Prueba CP-CAD-09
- **Título:** Eliminación en cadena compuesta únicamente por espacios en blanco ("     " $\to$ `""`)
- **Prioridad:** 2 (Media)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `StringManipulatorTests.RemoveSpaces_OnlySpaces_ReturnsEmptyString`
- **Precondiciones:** Instancia de `StringManipulator` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Definir cadena con solo 5 espacios: `"     "`. | Entrada configurada correctamente. |
  | 2 | Ejecutar método `RemoveSpaces("     ")`. | Se vacía la cadena completamente. |
  | 3 | Evaluar aserción `Assert.Equal(string.Empty, actual)`. | La aserción es exitosa. Retorna `""`. |
- **Resultado:** ✅ Superado (Passed)

### Caso de Prueba CP-CAD-10
- **Título:** Validación de excepción ante entrada nula en eliminación de espacios
- **Prioridad:** 1 (Alta)
- **Estado:** Ready / Automated
- **Método de prueba automatizado:** `StringManipulatorTests.RemoveSpaces_NullInput_ThrowsArgumentNullException`
- **Precondiciones:** Instancia de `StringManipulator` inicializada.
- **Pasos de ejecución:**
  | Paso | Acción | Resultado Esperado |
  | :--- | :--- | :--- |
  | 1 | Pasar valor `null` al método `RemoveSpaces`. | La invocación se ejecuta. |
  | 2 | Evaluar mediante `Assert.Throws<ArgumentNullException>`. | Se captura la excepción `ArgumentNullException`. |
- **Resultado:** ✅ Superado (Passed)

---

## 📌 Guía Paso a Paso para Registrar en Azure DevOps

Para registrar estos casos de prueba en tu cuenta de Azure DevOps y capturar las evidencias:

1. **Ingresar a Azure DevOps:**
   - Ve a [https://dev.azure.com](https://dev.azure.com) e inicia sesión con tu cuenta institucional o personal.
2. **Crear o Abrir Proyecto:**
   - Si no tienes proyecto, haz clic en **+ New Project**.
   - Nombre sugerido: `GuiaPractica1-PruebasUnitarias-COJP`.
   - Visibilidad: **Public** o **Private**.
3. **Ir al Módulo de Pruebas:**
   - En el menú lateral izquierdo, selecciona **Test Plans** > **Test Plans** (o **Boards** > **Work Items** si tu plan básico no tiene extensión Test Plans activa).
4. **Crear las Test Suites:**
   - Haz clic en **+ New Test Suite** > **Static Suite**.
   - Crear Suite 1: `COJP.Temperatura - MSTest`
   - Crear Suite 2: `COJP.Cadenas - xUnit`
5. **Registrar los Casos de Prueba (Test Cases):**
   - Dentro de cada Suite, haz clic en **+ New Test Case**.
   - Asigna el título (ej: `CP-TEMP-01: Conversión de Celsius a Fahrenheit en punto de congelación`).
   - En la sección **Steps**, agrega las acciones y resultados esperados listados en esta tabla.
   - Guarda el Test Case (**Save & Close**).
6. **Tomar Capturas de Pantalla con Fecha y Hora:**
   - Asegúrate de que la barra de tareas de Windows sea visible en la captura, mostrando la fecha y la hora actual en la esquina inferior derecha.
