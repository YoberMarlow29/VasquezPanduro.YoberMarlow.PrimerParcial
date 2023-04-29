namespace EntidadesParcial
{
    public abstract class Viaje
    {
        public enum PuntoPartida
        {
            BuenosAires_Argentina
        };
        protected PuntoPartida aeropuerto;
        protected DateTime fechaInicio;
        protected DateTime fechaActual;
        protected Aeronave avion;
        protected int cantidadCamarotesPremium;
        protected int cantidadCamarotesTurista;
        protected float precioPremiumBruto;
        protected float precioTuristaBruto;
        protected int duracionHoras;

    }
}