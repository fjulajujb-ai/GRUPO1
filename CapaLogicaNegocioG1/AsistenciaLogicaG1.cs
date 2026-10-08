namespace CapaLogicaNegocioG1
{
    public class AsistenciaLogicaG1
    {
        // Método (Sub + Nombre + G1)
        public decimal SubCalcularHorasExtrasG1(decimal salarioBase, decimal horasExtras)
        {
            if (salarioBase <= 0) return 0;

            // Fórmula: (Salario Base Mensual / 30 / Horas Jornada) * 1.5 * Cantidad Horas Extras
            decimal valorHoraNormal = salarioBase / 30 / 8;
            decimal valorHoraExtra = valorHoraNormal * 1.5m;

            return valorHoraExtra * horasExtras;
        }
    }
}