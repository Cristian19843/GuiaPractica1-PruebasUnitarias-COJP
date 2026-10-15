namespace COJP.Temperatura
{
    /// <summary>
    /// Proporciona métodos para convertir temperaturas entre diferentes escalas (Celsius y Fahrenheit).
    /// </summary>
    public class TemperatureConverter
    {
        /// <summary>
        /// Convierte una temperatura de grados Celsius a grados Fahrenheit.
        /// Fórmula: (°C * 9 / 5) + 32
        /// </summary>
        /// <param name="celsius">Temperatura en grados Celsius.</param>
        /// <returns>Temperatura equivalente en grados Fahrenheit.</returns>
        public double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9.0 / 5.0) + 32.0;
        }

        /// <summary>
        /// Convierte una temperatura de grados Fahrenheit a grados Celsius.
        /// Fórmula: (°F - 32) * 5 / 9
        /// </summary>
        /// <param name="fahrenheit">Temperatura en grados Fahrenheit.</param>
        /// <returns>Temperatura equivalente en grados Celsius.</returns>
        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32.0) * 5.0 / 9.0;
        }
    }
}
