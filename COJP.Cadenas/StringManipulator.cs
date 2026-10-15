namespace COJP.Cadenas
{
    /// <summary>
    /// Proporciona métodos para realizar manipulaciones comunes sobre cadenas de texto.
    /// </summary>
    public class StringManipulator
    {
        /// <summary>
        /// Invierte el orden de los caracteres en una cadena dada.
        /// </summary>
        /// <param name="input">La cadena de texto a invertir.</param>
        /// <returns>La cadena con sus caracteres en orden inverso.</returns>
        /// <exception cref="ArgumentNullException">Se lanza si la cadena proporcionada es nula.</exception>
        public string ReverseString(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "La cadena no puede ser nula.");
            }

            if (input.Length <= 1)
            {
                return input;
            }

            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        /// <summary>
        /// Elimina todos los espacios en blanco de una cadena dada.
        /// </summary>
        /// <param name="input">La cadena de texto con posibles espacios.</param>
        /// <returns>La cadena sin ningún espacio en blanco.</returns>
        /// <exception cref="ArgumentNullException">Se lanza si la cadena proporcionada es nula.</exception>
        public string RemoveSpaces(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "La cadena no puede ser nula.");
            }

            return input.Replace(" ", string.Empty);
        }
    }
}
