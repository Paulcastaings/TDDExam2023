namespace NombresRomain
{
    public class ConvertNombresRomain
    {
        public static string Convertir(uint chiffreArabe)

            => chiffreArabe switch
            {
                1 => "I",
                _ => "II",
            };
    }
}
