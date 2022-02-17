using AppVuelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppVuelos
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Datos de los clientes
            var clientes = new List<Cliente>();

            clientes.Add(new Cliente 
            { ClienteId = 1, Nombre = "Raul", Apellido = "Jaramillo", Identificacion = "1110234654", CorreoElectronico = "rjaramillo@gmail.com", CelularContacto = "3007839201", 
                FechaNacimiento = new DateTime(1984, 10, 11), Ciudad = "Barbosa", Estado = "Antioquia", Pais = "Colombia" });
            clientes.Add(new Cliente 
            { ClienteId = 2, Nombre = "Estefania", Apellido = "Cabello", Identificacion = "24328792-8", CorreoElectronico = "estefacabello@outlock.com", CelularContacto = "978942543", 
                FechaNacimiento = new DateTime(1991, 2, 27), Ciudad = "Arequipa", Estado = "Arequipa", Pais = "Peru" });
            clientes.Add(new Cliente 
            { ClienteId = 3, Nombre = "Patricio", Apellido = "Canales", Identificacion = "512535-6", CorreoElectronico = "paticocanales@yahoo.es", CelularContacto = "932155465", 
                FechaNacimiento = new DateTime(2000, 5, 23), Ciudad = "Valparaiso", Estado = "Valparaiso", Pais = "Chile" });
            clientes.Add(new Cliente 
            { ClienteId = 4, Nombre = "Adriana", Apellido = "Quintana", Identificacion = "1114745824", CorreoElectronico = "quintana23@gmail.com", CelularContacto = "3246548989", 
                FechaNacimiento = new DateTime(1989, 7, 2), Ciudad = "Santa Marta", Estado = "Magdalena", Pais = "Colombia" });
            clientes.Add(new Cliente 
            { ClienteId = 5, Nombre = "Victoria", Apellido = "Aldana", Identificacion = "98765322", CorreoElectronico = "vickyaldana@gmail.com", CelularContacto = "3179182345", 
                FechaNacimiento = new DateTime(1980, 12, 15), Ciudad = "Cali", Estado = "Valle del Cauca", Pais = "Colombia" });
            clientes.Add(new Cliente 
            { ClienteId = 6, Nombre = "Juan", Apellido = "Martinez", Identificacion = "94567322", CorreoElectronico = "juanmartinez@live.com", CelularContacto = "3184930290", 
                FechaNacimiento = new DateTime(1979, 4, 30), Ciudad = "Bogota", Estado = "Bogota DC", Pais = "Colombia" });
            clientes.Add(new Cliente 
            { ClienteId = 7, Nombre = "Mariana", Apellido = "Duran", Identificacion = "72837900", CorreoElectronico = "duranduran@gmail.com", CelularContacto = "3138599043", 
                FechaNacimiento = new DateTime(1975, 6, 7), Ciudad = "Montenegro", Estado = "Quindio", Pais = "Colombia" });
            clientes.Add(new Cliente 
            { ClienteId = 8, Nombre = "Raul", Apellido = "Estrada", Identificacion = "CGOV324HESAD350DU89", CorreoElectronico = "estradaraulito@hotmail.es", CelularContacto = "5598573264", 
                FechaNacimiento = new DateTime(1987, 8, 10), Ciudad = "Ciudad de Mexico", Estado = "Mexico", Pais = "Mexico" });
            clientes.Add(new Cliente 
            { ClienteId = 9, Nombre = "Maria Luisa", Apellido = "Bernal", Identificacion = "54987654", CorreoElectronico = "lamuyindigna@gmail.com", CelularContacto = "3108734000", 
                FechaNacimiento = new DateTime(1970, 3, 31), Ciudad = "Pasto", Estado = "Nariño", Pais = "Colombia" });
            clientes.Add(new Cliente 
            { ClienteId = 10, Nombre = "Pedro", Apellido = "Sotomayor", Identificacion = "1114908670", CorreoElectronico = "pedrosotom20@gmail.com", CelularContacto = "3249870098", 
                FechaNacimiento = new DateTime(1997, 1, 21), Ciudad = "Cali", Estado = "Valle del Cauca", Pais = "Colombia" });

            //Aerolineas y vuelos por aerolinea
            var aerolineas = new List<Aerolinea>();

            aerolineas.Add(new Aerolinea { AerolineaId = 1, NombreAerolinea = "AeroMexico", VueloAerolinea = new List<string> { "AMX908", "AMX500", "AMX170", "AMX814", "AMX504" } });
            aerolineas.Add(new Aerolinea { AerolineaId = 2, NombreAerolinea = "AmericanAirlines", VueloAerolinea = new List<string> { "AAL1835", "AAL1066", "AAL1374", "AAL2415", "AAL828" } });
            aerolineas.Add(new Aerolinea { AerolineaId = 3, NombreAerolinea = "Avianca", VueloAerolinea = new List<string> { "AV9313", "AV8573", "AV9844", "AV8431", "AV42" } });
            aerolineas.Add(new Aerolinea { AerolineaId = 4, NombreAerolinea = "CopaAirlines", VueloAerolinea = new List<string> { "CM15", "CM121", "CM127", "CM242", "CM881" } });
            aerolineas.Add(new Aerolinea { AerolineaId = 5, NombreAerolinea = "Iberia", VueloAerolinea = new List<string> { "IB442", "IB2034", "IB3123", "IB6253", "IB8828" } });
            aerolineas.Add(new Aerolinea { AerolineaId = 6, NombreAerolinea = "Latam", VueloAerolinea = new List<string> { "LA4009", "LA4286", "LA4294", "LA4306", "LA4428" } });
            aerolineas.Add(new Aerolinea { AerolineaId = 7, NombreAerolinea = "United", VueloAerolinea = new List<string> { "UA32", "UA47", "UA59", "UA219", "UA331" } });
            aerolineas.Add(new Aerolinea { AerolineaId = 8, NombreAerolinea = "VivaAir", VueloAerolinea = new List<string> { "VH606", "VH321", "VH5587", "VH5676", "VH5978" } });
            aerolineas.Add(new Aerolinea { AerolineaId = 9, NombreAerolinea = "Wingo", VueloAerolinea = new List<string> { "P57069", "P57207", "P57284", "P7436", "P57275" } });

            // Tiquetes
            var tiquetes = new List<Tiquetes>();

            tiquetes.Add(new Tiquetes { TiqueteId = 1, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 1, CiudadOrigenId = 9, CiudadDestinoId = 1, FechaCompra = new DateTime(2021, 12, 12), FechaVuelo = new DateTime(2022, 1, 13, 9, 30, 00), ValorUnitario = 59000, Cantidad = 2 });
            tiquetes.Add(new Tiquetes { TiqueteId = 2, AerolineaId = 8, NumeroVuelo = "VH5587", ClienteId = 6, CiudadOrigenId = 1, CiudadDestinoId = 10, FechaCompra = new DateTime(2021, 12, 23), FechaVuelo = new DateTime(2022, 1, 24, 6, 15, 00), ValorUnitario = 442000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 3, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 4, CiudadOrigenId = 17, CiudadDestinoId = 16, FechaCompra = new DateTime(2022, 1, 12), FechaVuelo = new DateTime(2022, 1, 14, 7, 45, 00), ValorUnitario = 213000, Cantidad = 2 });
            tiquetes.Add(new Tiquetes { TiqueteId = 4, AerolineaId = 8, NumeroVuelo = "VH321", ClienteId = 7, CiudadOrigenId = 0, CiudadDestinoId = 14, FechaCompra = new DateTime(2022, 2, 12), FechaVuelo = new DateTime(2022, 3, 30, 7, 20, 00), ValorUnitario = 753000, Cantidad = 2 });
            tiquetes.Add(new Tiquetes { TiqueteId = 5, AerolineaId = 8, NumeroVuelo = "VH5587", ClienteId = 2, CiudadOrigenId = 8, CiudadDestinoId = 12, FechaCompra = new DateTime(2021, 12, 12), FechaVuelo = new DateTime(2022, 1, 8, 5, 30, 00), ValorUnitario = 565000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 6, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 10, CiudadOrigenId = 3, CiudadDestinoId = 14, FechaCompra = new DateTime(2022, 2, 2), FechaVuelo = new DateTime(2022, 2, 12, 9, 30, 00), ValorUnitario = 605000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 7, AerolineaId = 8, NumeroVuelo = "VH5676", ClienteId = 3, CiudadOrigenId = 18, CiudadDestinoId = 1, FechaCompra = new DateTime(2022, 1, 29), FechaVuelo = new DateTime(2022, 2, 3, 4, 30, 00), ValorUnitario = 735000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 8, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 5, CiudadOrigenId = 3, CiudadDestinoId = 1, FechaCompra = new DateTime(2022, 1, 6), FechaVuelo = new DateTime(2022, 1, 13, 10, 30, 00), ValorUnitario = 59000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 9, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 8, CiudadOrigenId = 10, CiudadDestinoId = 12, FechaCompra = new DateTime(2021, 12, 30), FechaVuelo = new DateTime(2022, 1, 17, 9, 30, 00), ValorUnitario = 59000, Cantidad = 2 });
            tiquetes.Add(new Tiquetes { TiqueteId = 10, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 9, CiudadOrigenId = 13, CiudadDestinoId = 1, FechaCompra = new DateTime(2022, 1, 21), FechaVuelo = new DateTime(2022, 2, 3, 7, 30, 00), ValorUnitario = 59000, Cantidad = 2 });

            //foreach (var item in tiquetes)
            //{
            //    Console.WriteLine($"\nAerolinea: {item.AerolineaId} \nCiudad Origen: {item.CiudadOrigenId} \nDestino: {item.CiudadDestinoId} \nCantidad: {item.Cantidad} \nValor Total: {item.Total} \nFecha de Compra: {item.FechaCompra} \nFecha de Viaje: {item.FechaVuelo}");
            //}

            Console.WriteLine("\nFecha Vuelos de Salida\n");

            Program pr = new Program();

            pr.ObtenerVuelosDeSalida("VH606", new DateTime(2022, 1, 13));

            // mostrar los vuelos por semana, quincenal, etc
            Console.WriteLine("\nInforme de vuelos por fecha\n\n" +
                "          Salida          -          Llegada\n");

            pr.ObtenerVuelosPorFecha(new DateTime(2022, 1, 9, 0, 0, 0), new DateTime(2022, 1, 9, 0, 0, 0).AddDays(7));

            Console.WriteLine();

            pr.ObtenerVuelosUsandoGroup();

            pr.ObtenerInformacionTiquetesVendidos();

            pr.ObtenerClientesPorVuelo();

            pr.ObtenerInformeSobreVuelos();

            //var vuelos = from aero in aerolineas
            //            select aero;

            //foreach (var aerolinea in vuelos) 
            //{
            //    Console.WriteLine($"\nAerolinea = {aerolinea.NombreAerolinea}");

            //    foreach (var vueloAe in aerolinea.VueloAerolinea)
            //    {
            //        Console.WriteLine($"    {vueloAe}");
            //    }
            //}

            //vuelos.Add(new Vuelo { VueloId = "AB3222", AerolineaId = 2, SalidaProgramada = new DateTime(2022, 1, 13, 9, 30, 00), SalidaActual = new DateTime(2022, 1, 13, 9, 35, 00), HoraLlegadaProgramada = new DateTime(2022, 1, 13, 11, 35, 00), EstadoVuelo = "Aterrizó" });

            Console.WriteLine();

            //foreach (var item in clientes)
            //{
            //    Console.WriteLine($"Nombre completo del cliente: {item.Nombre} {item.Apellido} - Identificación: {item.Identificacion} - Pais: {item.Pais}");
            //}
        }

        void ObtenerVuelosDeSalida(string idVuelo, DateTime fecha)
        {
            // Vuelos salida
            var vuelosSalida = new List<VuelosNacionales.VueloSalida>();

            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 1, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 13, 9, 30, 00), CiudadDestino = 1 });//bogota
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 2, VueloId = "VH5587", FechaVuelo = new DateTime(2022, 1, 24, 6, 15, 00), CiudadDestino = 10 });//mexico
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 3, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 14, 7, 45, 00), CiudadDestino = 16 });//san andres
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 4, VueloId = "VH321", FechaVuelo = new DateTime(2022, 3, 30, 7, 20, 00), CiudadDestino = 14 });//punta cana
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 5, VueloId = "VH5587", FechaVuelo = new DateTime(2022, 1, 8, 5, 30, 00), CiudadDestino = 12 });//orlando
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 6, VueloId = "VH606", FechaVuelo = new DateTime(2022, 2, 12, 9, 30, 00), CiudadDestino = 14 });//punta cana
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 7, VueloId = "VH5676", FechaVuelo = new DateTime(2022, 2, 3, 4, 30, 00), CiudadDestino = 1 });//bogota
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 8, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 13, 10, 30, 00), CiudadDestino = 1 });//bogota
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 9, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 17, 9, 30, 00), CiudadDestino = 12 });//orlando
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 10, VueloId = "VH606", FechaVuelo = new DateTime(2022, 2, 3, 7, 30, 00), CiudadDestino = 1 });//bogota

            var listadoVuelos = from vs in vuelosSalida
                                where vs.VueloId == idVuelo && vs.FechaVuelo.ToLongDateString() == fecha.ToLongDateString()
                                orderby vs.FechaVuelo.ToLongDateString()
                                select vs;

            foreach (var item in listadoVuelos)
            {
                Console.WriteLine($"{item.FechaVuelo} - Vuelo {item.VueloId}");
            }
        }

        void ObtenerVuelosPorFecha(DateTime fechaInicial, DateTime fechaFinal)
        {
            // Vuelos salida
            var vuelosSalida = new List<VuelosNacionales.VueloSalida>();

            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 1, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 13, 9, 30, 00), CiudadDestino = 1, VueloLlegadaId = 1 });//bogota
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 2, VueloId = "VH5587", FechaVuelo = new DateTime(2022, 1, 24, 6, 15, 00), CiudadDestino = 10, VueloLlegadaId = 2 });//mexico
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 3, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 14, 7, 45, 00), CiudadDestino = 16, VueloLlegadaId = 3 });//san andres
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 4, VueloId = "VH321", FechaVuelo = new DateTime(2022, 3, 30, 7, 20, 00), CiudadDestino = 14, VueloLlegadaId = 4 });//punta cana
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 5, VueloId = "VH5587", FechaVuelo = new DateTime(2022, 1, 8, 5, 30, 00), CiudadDestino = 12, VueloLlegadaId = 5 });//orlando
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 6, VueloId = "VH606", FechaVuelo = new DateTime(2022, 2, 12, 9, 30, 00), CiudadDestino = 14, VueloLlegadaId = 6 });//punta cana
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 7, VueloId = "VH5676", FechaVuelo = new DateTime(2022, 2, 3, 4, 30, 00), CiudadDestino = 1, VueloLlegadaId = 7 });//bogota
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 8, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 13, 10, 30, 00), CiudadDestino = 1, VueloLlegadaId = 8 });//bogota
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 9, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 17, 9, 30, 00), CiudadDestino = 12, VueloLlegadaId = 9 });//orlando
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 10, VueloId = "VH606", FechaVuelo = new DateTime(2022, 2, 3, 7, 30, 00), CiudadDestino = 1, VueloLlegadaId = 10 });//bogota

            // Vuelos llegada
            var vuelosLlegada = new List<VuelosNacionales.VueloLlegada>();

            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 1, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 13, 10, 20, 00), CiudadOrigenId = 9, VueloSalidaId = 1 });//medellin
            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 2, VueloId = "VH5587", FechaVuelo = new DateTime(2022, 1, 24, 8, 45, 00), CiudadOrigenId = 1, VueloSalidaId = 2 });//bogota
            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 3, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 14, 9, 15, 00), CiudadOrigenId = 17, VueloSalidaId = 3 });//santa marta
            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 4, VueloId = "VH321", FechaVuelo = new DateTime(2022, 3, 30, 9, 50, 00), CiudadOrigenId = 0, VueloSalidaId = 4 });//armenia
            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 5, VueloId = "VH5587", FechaVuelo = new DateTime(2022, 1, 8, 8, 40, 00), CiudadOrigenId = 8, VueloSalidaId = 5 });//lima
            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 6, VueloId = "VH606", FechaVuelo = new DateTime(2022, 2, 12, 13, 30, 00), CiudadOrigenId = 3, VueloSalidaId = 6 });//cali
            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 7, VueloId = "VH5676", FechaVuelo = new DateTime(2022, 2, 3, 6, 40, 00), CiudadOrigenId = 18, VueloSalidaId = 7 });//santiago de chile
            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 8, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 13, 11, 25, 00), CiudadOrigenId = 3, VueloSalidaId = 8 });//cali
            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 9, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 17, 10, 50, 00), CiudadOrigenId = 10, VueloSalidaId = 9 });//mexico
            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 10, VueloId = "VH606", FechaVuelo = new DateTime(2022, 2, 3, 8, 35, 00), CiudadOrigenId = 13, VueloSalidaId = 10 });//pasto

            var vuelosPorSemana = from vs in vuelosSalida
                                  join vll in vuelosLlegada
                                  on vs.Id equals vll.VueloSalidaId
                                  orderby vs.FechaVuelo
                                  //orderby vll.FechaVuelo
                                  select new { Salida = vs, Llegada = vll };

            foreach (var item in vuelosPorSemana)
            {
                if ((Convert.ToDateTime(item.Salida.FechaVuelo.ToLongDateString()) >= fechaInicial) && (Convert.ToDateTime(item.Llegada.FechaVuelo.ToLongDateString()) <= fechaFinal))
                {
                    Console.WriteLine(item.Salida.FechaVuelo + " - " + item.Llegada.FechaVuelo);
                }
            }
        }

        public void ObtenerVuelosUsandoGroup()
        {
            // Vuelos salida
            var vuelosSalida = new List<VuelosNacionales.VueloSalida>();

            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 1, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 13, 9, 30, 00), CiudadDestino = 1, VueloLlegadaId = 1 });//bogota
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 2, VueloId = "VH5587", FechaVuelo = new DateTime(2022, 1, 24, 6, 15, 00), CiudadDestino = 10, VueloLlegadaId = 2 });//mexico
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 3, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 14, 7, 45, 00), CiudadDestino = 16, VueloLlegadaId = 3 });//san andres
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 4, VueloId = "VH321", FechaVuelo = new DateTime(2022, 3, 30, 7, 20, 00), CiudadDestino = 14, VueloLlegadaId = 4 });//punta cana
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 5, VueloId = "VH5587", FechaVuelo = new DateTime(2022, 1, 8, 5, 30, 00), CiudadDestino = 12, VueloLlegadaId = 5 });//orlando
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 6, VueloId = "VH606", FechaVuelo = new DateTime(2022, 2, 12, 9, 30, 00), CiudadDestino = 14, VueloLlegadaId = 6 });//punta cana
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 7, VueloId = "VH5676", FechaVuelo = new DateTime(2022, 2, 3, 4, 30, 00), CiudadDestino = 1, VueloLlegadaId = 7 });//bogota
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 8, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 13, 10, 30, 00), CiudadDestino = 1, VueloLlegadaId = 8 });//bogota
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 9, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 17, 9, 30, 00), CiudadDestino = 12, VueloLlegadaId = 9 });//orlando
            vuelosSalida.Add(new VuelosNacionales.VueloSalida { Id = 10, VueloId = "VH606", FechaVuelo = new DateTime(2022, 2, 3, 7, 30, 00), CiudadDestino = 1, VueloLlegadaId = 10 });//bogota

            // Vuelos llegada
            var vuelosLlegada = new List<VuelosNacionales.VueloLlegada>();

            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 1, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 13, 10, 20, 00), CiudadOrigenId = 9, VueloSalidaId = 1 });//medellin
            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 2, VueloId = "VH5587", FechaVuelo = new DateTime(2022, 1, 24, 8, 45, 00), CiudadOrigenId = 1, VueloSalidaId = 2 });//bogota
            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 3, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 14, 9, 15, 00), CiudadOrigenId = 17, VueloSalidaId = 3 });//santa marta
            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 4, VueloId = "VH321", FechaVuelo = new DateTime(2022, 3, 30, 9, 50, 00), CiudadOrigenId = 0, VueloSalidaId = 4 });//armenia
            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 5, VueloId = "VH5587", FechaVuelo = new DateTime(2022, 1, 8, 8, 40, 00), CiudadOrigenId = 8, VueloSalidaId = 5 });//lima
            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 6, VueloId = "VH606", FechaVuelo = new DateTime(2022, 2, 12, 13, 30, 00), CiudadOrigenId = 3, VueloSalidaId = 6 });//cali
            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 7, VueloId = "VH5676", FechaVuelo = new DateTime(2022, 2, 3, 6, 40, 00), CiudadOrigenId = 18, VueloSalidaId = 7 });//santiago de chile
            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 8, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 13, 11, 25, 00), CiudadOrigenId = 3, VueloSalidaId = 8 });//cali
            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 9, VueloId = "VH606", FechaVuelo = new DateTime(2022, 1, 17, 10, 50, 00), CiudadOrigenId = 10, VueloSalidaId = 9 });//mexico
            vuelosLlegada.Add(new VuelosNacionales.VueloLlegada { Id = 10, VueloId = "VH606", FechaVuelo = new DateTime(2022, 2, 3, 8, 35, 00), CiudadOrigenId = 13, VueloSalidaId = 10 });//pasto

            var consultaVuelos = from vs in vuelosSalida
                                 group vs by vs.VueloId into vuelos
                                 orderby vuelos.Key
                                 select vuelos;

            foreach (var vuelo in consultaVuelos)
            {
                Console.WriteLine($"\nVuelo: {vuelo.Key}");

                foreach (var item in vuelo)
                {
                    Console.WriteLine($"Fecha: {item.FechaVuelo} Destino: {item.CiudadDestino}");
                }
            }
        }

        public void ObtenerInformacionTiquetesVendidos()
        {
            // Tiquetes
            var tiquetes = new List<Tiquetes>();

            tiquetes.Add(new Tiquetes { TiqueteId = 1, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 1, CiudadOrigenId = 9, CiudadDestinoId = 1, FechaCompra = new DateTime(2021, 12, 12), FechaVuelo = new DateTime(2022, 1, 13, 9, 30, 00), ValorUnitario = 59000, Cantidad = 2 });
            tiquetes.Add(new Tiquetes { TiqueteId = 2, AerolineaId = 8, NumeroVuelo = "VH5587", ClienteId = 6, CiudadOrigenId = 1, CiudadDestinoId = 10, FechaCompra = new DateTime(2021, 12, 23), FechaVuelo = new DateTime(2022, 1, 24, 6, 15, 00), ValorUnitario = 442000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 3, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 4, CiudadOrigenId = 17, CiudadDestinoId = 16, FechaCompra = new DateTime(2022, 1, 12), FechaVuelo = new DateTime(2022, 1, 14, 7, 45, 00), ValorUnitario = 213000, Cantidad = 2 });
            tiquetes.Add(new Tiquetes { TiqueteId = 4, AerolineaId = 8, NumeroVuelo = "VH321", ClienteId = 7, CiudadOrigenId = 0, CiudadDestinoId = 14, FechaCompra = new DateTime(2022, 2, 12), FechaVuelo = new DateTime(2022, 3, 30, 7, 20, 00), ValorUnitario = 753000, Cantidad = 2 });
            tiquetes.Add(new Tiquetes { TiqueteId = 5, AerolineaId = 8, NumeroVuelo = "VH5587", ClienteId = 2, CiudadOrigenId = 8, CiudadDestinoId = 12, FechaCompra = new DateTime(2021, 12, 12), FechaVuelo = new DateTime(2022, 1, 8, 5, 30, 00), ValorUnitario = 565000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 6, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 10, CiudadOrigenId = 3, CiudadDestinoId = 14, FechaCompra = new DateTime(2022, 2, 2), FechaVuelo = new DateTime(2022, 2, 12, 9, 30, 00), ValorUnitario = 605000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 7, AerolineaId = 8, NumeroVuelo = "VH5676", ClienteId = 3, CiudadOrigenId = 18, CiudadDestinoId = 1, FechaCompra = new DateTime(2022, 1, 29), FechaVuelo = new DateTime(2022, 2, 3, 4, 30, 00), ValorUnitario = 735000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 8, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 5, CiudadOrigenId = 3, CiudadDestinoId = 1, FechaCompra = new DateTime(2022, 1, 6), FechaVuelo = new DateTime(2022, 1, 13, 10, 30, 00), ValorUnitario = 59000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 9, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 8, CiudadOrigenId = 10, CiudadDestinoId = 12, FechaCompra = new DateTime(2021, 12, 30), FechaVuelo = new DateTime(2022, 1, 17, 9, 30, 00), ValorUnitario = 59000, Cantidad = 2 });
            tiquetes.Add(new Tiquetes { TiqueteId = 10, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 9, CiudadOrigenId = 13, CiudadDestinoId = 1, FechaCompra = new DateTime(2022, 1, 21), FechaVuelo = new DateTime(2022, 2, 3, 7, 30, 00), ValorUnitario = 59000, Cantidad = 2 });

            /*
            var consulta = tiquetes.GroupBy(
                tiquete => tiquete.NumeroVuelo,
                (infoVuelos, vuelos) => new
                {
                    Clave = infoVuelos,
                    TotalVuelos = infoVuelos.Count(),
                    Vuelos = infoVuelos.Contains(infoVuelos)
                });

            foreach (var item in consulta)
            {
                Console.WriteLine($"\nVuelo Clave {item.Clave}\nTotal Vuelos {item.TotalVuelos}");
            }
             */

            IEnumerable<IGrouping<string, DateTime>> consulta =
                tiquetes.OrderBy(x => x.FechaCompra).GroupBy(vuelo => vuelo.NumeroVuelo, vuelo => vuelo.FechaCompra.Value).OrderBy(x => x.Key);

            Console.WriteLine("\n*** Informe Vuelos Ordenados Por Fecha De Compra ***");
            foreach (IGrouping<string, DateTime> item in consulta)
            {
                Console.WriteLine($"\n{item.Key}");

                foreach (DateTime fecha in item)
                {
                    Console.WriteLine($"Fecha Compra {fecha}");
                }
            }
        }

        public void ObtenerClientesPorVuelo()
        {
            //Clientes
            var clientes = new List<Cliente>();

            clientes.Add(new Cliente 
            { ClienteId = 1, Nombre = "Raul", Apellido = "Jaramillo", Identificacion = "1110234654", CorreoElectronico = "rjaramillo@gmail.com", CelularContacto = "3007839201", 
                FechaNacimiento = new DateTime(1984, 10, 11), Ciudad = "Barbosa", Estado = "Antioquia", Pais = "Colombia" });
            clientes.Add(new Cliente 
            { ClienteId = 2, Nombre = "Estefania", Apellido = "Cabello", Identificacion = "24328792-8", CorreoElectronico = "estefacabello@outlock.com", CelularContacto = "978942543", 
                FechaNacimiento = new DateTime(1991, 2, 27), Ciudad = "Arequipa", Estado = "Arequipa", Pais = "Peru" });
            clientes.Add(new Cliente 
            { ClienteId = 3, Nombre = "Patricio", Apellido = "Canales", Identificacion = "512535-6", CorreoElectronico = "paticocanales@yahoo.es", CelularContacto = "932155465", 
                FechaNacimiento = new DateTime(2000, 5, 23), Ciudad = "Valparaiso", Estado = "Valparaiso", Pais = "Chile" });
            clientes.Add(new Cliente 
            { ClienteId = 4, Nombre = "Adriana", Apellido = "Quintana", Identificacion = "1114745824", CorreoElectronico = "quintana23@gmail.com", CelularContacto = "3246548989", 
                FechaNacimiento = new DateTime(1989, 7, 2), Ciudad = "Santa Marta", Estado = "Magdalena", Pais = "Colombia" });
            clientes.Add(new Cliente 
            { ClienteId = 5, Nombre = "Victoria", Apellido = "Aldana", Identificacion = "98765322", CorreoElectronico = "vickyaldana@gmail.com", CelularContacto = "3179182345", 
                FechaNacimiento = new DateTime(1980, 12, 15), Ciudad = "Cali", Estado = "Valle del Cauca", Pais = "Colombia" });
            clientes.Add(new Cliente 
            { ClienteId = 6, Nombre = "Juan", Apellido = "Martinez", Identificacion = "94567322", CorreoElectronico = "juanmartinez@live.com", CelularContacto = "3184930290", 
                FechaNacimiento = new DateTime(1979, 4, 30), Ciudad = "Bogota", Estado = "Bogota DC", Pais = "Colombia" });
            clientes.Add(new Cliente 
            { ClienteId = 7, Nombre = "Mariana", Apellido = "Duran", Identificacion = "72837900", CorreoElectronico = "duranduran@gmail.com", CelularContacto = "3138599043", 
                FechaNacimiento = new DateTime(1975, 6, 7), Ciudad = "Montenegro", Estado = "Quindio", Pais = "Colombia" });
            clientes.Add(new Cliente 
            { ClienteId = 8, Nombre = "Raul", Apellido = "Estrada", Identificacion = "CGOV324HESAD350DU89", CorreoElectronico = "estradaraulito@hotmail.es", CelularContacto = "5598573264", 
                FechaNacimiento = new DateTime(1987, 8, 10), Ciudad = "Ciudad de Mexico", Estado = "Mexico", Pais = "Mexico" });
            clientes.Add(new Cliente 
            { ClienteId = 9, Nombre = "Maria Luisa", Apellido = "Bernal", Identificacion = "54987654", CorreoElectronico = "lamuyindigna@gmail.com", CelularContacto = "3108734000", 
                FechaNacimiento = new DateTime(1970, 3, 31), Ciudad = "Pasto", Estado = "Nariño", Pais = "Colombia" });
            clientes.Add(new Cliente 
            { ClienteId = 10, Nombre = "Pedro", Apellido = "Sotomayor", Identificacion = "1114908670", CorreoElectronico = "pedrosotom20@gmail.com", CelularContacto = "3249870098", 
                FechaNacimiento = new DateTime(1997, 1, 21), Ciudad = "Cali", Estado = "Valle del Cauca", Pais = "Colombia" });

            // Tiquetes
            var tiquetes = new List<Tiquetes>();

            tiquetes.Add(new Tiquetes { TiqueteId = 1, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 1, CiudadOrigenId = 9, CiudadDestinoId = 1, FechaCompra = new DateTime(2021, 12, 12), FechaVuelo = new DateTime(2022, 1, 13, 9, 30, 00), ValorUnitario = 59000, Cantidad = 2 });
            tiquetes.Add(new Tiquetes { TiqueteId = 2, AerolineaId = 8, NumeroVuelo = "VH5587", ClienteId = 6, CiudadOrigenId = 1, CiudadDestinoId = 10, FechaCompra = new DateTime(2021, 12, 23), FechaVuelo = new DateTime(2022, 1, 24, 6, 15, 00), ValorUnitario = 442000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 3, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 4, CiudadOrigenId = 17, CiudadDestinoId = 16, FechaCompra = new DateTime(2022, 1, 12), FechaVuelo = new DateTime(2022, 1, 14, 7, 45, 00), ValorUnitario = 213000, Cantidad = 2 });
            tiquetes.Add(new Tiquetes { TiqueteId = 4, AerolineaId = 8, NumeroVuelo = "VH321", ClienteId = 7, CiudadOrigenId = 0, CiudadDestinoId = 14, FechaCompra = new DateTime(2022, 2, 12), FechaVuelo = new DateTime(2022, 3, 30, 7, 20, 00), ValorUnitario = 753000, Cantidad = 2 });
            tiquetes.Add(new Tiquetes { TiqueteId = 5, AerolineaId = 8, NumeroVuelo = "VH5587", ClienteId = 2, CiudadOrigenId = 8, CiudadDestinoId = 12, FechaCompra = new DateTime(2021, 12, 12), FechaVuelo = new DateTime(2022, 1, 8, 5, 30, 00), ValorUnitario = 565000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 6, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 10, CiudadOrigenId = 3, CiudadDestinoId = 14, FechaCompra = new DateTime(2022, 2, 2), FechaVuelo = new DateTime(2022, 2, 12, 9, 30, 00), ValorUnitario = 605000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 7, AerolineaId = 8, NumeroVuelo = "VH5676", ClienteId = 3, CiudadOrigenId = 18, CiudadDestinoId = 1, FechaCompra = new DateTime(2022, 1, 29), FechaVuelo = new DateTime(2022, 2, 3, 4, 30, 00), ValorUnitario = 735000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 8, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 5, CiudadOrigenId = 3, CiudadDestinoId = 1, FechaCompra = new DateTime(2022, 1, 6), FechaVuelo = new DateTime(2022, 1, 13, 10, 30, 00), ValorUnitario = 59000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 9, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 8, CiudadOrigenId = 10, CiudadDestinoId = 12, FechaCompra = new DateTime(2021, 12, 30), FechaVuelo = new DateTime(2022, 1, 17, 9, 30, 00), ValorUnitario = 59000, Cantidad = 2 });
            tiquetes.Add(new Tiquetes { TiqueteId = 10, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 9, CiudadOrigenId = 13, CiudadDestinoId = 1, FechaCompra = new DateTime(2022, 1, 21), FechaVuelo = new DateTime(2022, 2, 3, 7, 30, 00), ValorUnitario = 59000, Cantidad = 2 });

            var consulta = from tiquete in tiquetes
                           join cliente in clientes
                           on tiquete.ClienteId equals cliente.ClienteId
                           group tiquete by tiquete.ClienteId into cliente
                           orderby cliente.Key
                           from vuelo in cliente
                           group vuelo by vuelo.NumeroVuelo into vuelos
                           orderby vuelos.Key
                           select vuelos;

            Console.WriteLine("\nInformación de Vuelos por Cliente");

            foreach (var itemVuelo in consulta)
            {
                Console.WriteLine($"\n    Vuelo No.: {itemVuelo.Key}");

                foreach (var itemCiudad in itemVuelo)
                {
                    Console.WriteLine($" Cliente: {itemCiudad.ClienteId}  || Ciudad Origen: {itemCiudad.CiudadOrigenId}   || Ciudad Destino: {itemCiudad.CiudadDestinoId}   || Fecha Viaje: {itemCiudad.FechaVuelo}  ||  Aerolinea: {itemCiudad.AerolineaId}");
                }
            }
        }

        public void ObtenerInformeSobreVuelos()
        {
            // Tiquetes
            var tiquetes = new List<Tiquetes>();

            tiquetes.Add(new Tiquetes { TiqueteId = 1, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 1, CiudadOrigenId = 9, CiudadDestinoId = 1, FechaCompra = new DateTime(2021, 12, 12), FechaVuelo = new DateTime(2022, 1, 13, 9, 30, 00), ValorUnitario = 59000, Cantidad = 2 });
            tiquetes.Add(new Tiquetes { TiqueteId = 2, AerolineaId = 8, NumeroVuelo = "VH5587", ClienteId = 6, CiudadOrigenId = 1, CiudadDestinoId = 10, FechaCompra = new DateTime(2021, 12, 23), FechaVuelo = new DateTime(2022, 1, 24, 6, 15, 00), ValorUnitario = 442000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 3, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 4, CiudadOrigenId = 17, CiudadDestinoId = 16, FechaCompra = new DateTime(2022, 1, 12), FechaVuelo = new DateTime(2022, 1, 14, 7, 45, 00), ValorUnitario = 213000, Cantidad = 2 });
            tiquetes.Add(new Tiquetes { TiqueteId = 4, AerolineaId = 8, NumeroVuelo = "VH321", ClienteId = 7, CiudadOrigenId = 0, CiudadDestinoId = 14, FechaCompra = new DateTime(2022, 2, 12), FechaVuelo = new DateTime(2022, 3, 30, 7, 20, 00), ValorUnitario = 753000, Cantidad = 2 });
            tiquetes.Add(new Tiquetes { TiqueteId = 5, AerolineaId = 8, NumeroVuelo = "VH5587", ClienteId = 2, CiudadOrigenId = 8, CiudadDestinoId = 12, FechaCompra = new DateTime(2021, 12, 12), FechaVuelo = new DateTime(2022, 1, 8, 5, 30, 00), ValorUnitario = 565000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 6, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 10, CiudadOrigenId = 3, CiudadDestinoId = 14, FechaCompra = new DateTime(2022, 2, 2), FechaVuelo = new DateTime(2022, 2, 12, 9, 30, 00), ValorUnitario = 605000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 7, AerolineaId = 8, NumeroVuelo = "VH5676", ClienteId = 3, CiudadOrigenId = 18, CiudadDestinoId = 1, FechaCompra = new DateTime(2022, 1, 29), FechaVuelo = new DateTime(2022, 2, 3, 4, 30, 00), ValorUnitario = 735000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 8, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 5, CiudadOrigenId = 3, CiudadDestinoId = 1, FechaCompra = new DateTime(2022, 1, 6), FechaVuelo = new DateTime(2022, 1, 13, 10, 30, 00), ValorUnitario = 59000, Cantidad = 1 });
            tiquetes.Add(new Tiquetes { TiqueteId = 9, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 8, CiudadOrigenId = 10, CiudadDestinoId = 12, FechaCompra = new DateTime(2021, 12, 30), FechaVuelo = new DateTime(2022, 1, 17, 9, 30, 00), ValorUnitario = 59000, Cantidad = 2 });
            tiquetes.Add(new Tiquetes { TiqueteId = 10, AerolineaId = 8, NumeroVuelo = "VH606", ClienteId = 9, CiudadOrigenId = 13, CiudadDestinoId = 1, FechaCompra = new DateTime(2022, 1, 21), FechaVuelo = new DateTime(2022, 2, 3, 7, 30, 00), ValorUnitario = 59000, Cantidad = 2 });

            IEnumerable<IGrouping<string, int>> consulta = 
                tiquetes.GroupBy(p => p.NumeroVuelo, p => p.CiudadDestinoId).OrderBy(x => x.Key);

            Console.WriteLine("\n Informe sobre destinos según número de vuelo");

            foreach (IGrouping<string, int> vuelo in consulta)
            {
                Console.WriteLine($"\n Vuelo:{vuelo.Key}");

                foreach (var item in vuelo)
                {
                    Console.WriteLine($"Ciudad Destino: {item}");
                }
            }
        }
    }
}

/*
 Fecha Vuelos de Salida
13/01/2022 5:30:00 a. m. - Vuelo VH5587
13/01/2022 9:30:00 a. m. - Vuelo VH606
13/01/2022 9:30:00 a. m. - Vuelo VH606
13/01/2022 10:30:00 a. m. - Vuelo VH606
14/01/2022 7:45:00 a. m. - Vuelo VH606
24/01/2022 6:15:00 a. m. - Vuelo VH5587
3/02/2022 4:30:00 a. m. - Vuelo VH5676
3/02/2022 7:30:00 a. m. - Vuelo VH606
12/02/2022 9:30:00 a. m. - Vuelo VH606
30/03/2022 7:20:00 a. m. - Vuelo VH321
 */
