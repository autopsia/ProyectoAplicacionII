﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicio
{
    [ServiceContract]
    public interface IServiceReserva
    {
        [OperationContract]
        List<ReservaBE> listarReservasPorHuesped(String dni);

        [OperationContract]
        Boolean registrarReserva(DateTime fechaIngreso,
                                 DateTime fechaSalida,
                                 Int32 idTipoPago,
                                 Decimal monto,
                                 Int32 idAmbiente,
                                 List<HuespedBE> lstHuespedBE);
    }
}

[DataContract]
[Serializable]
public class ReservaBE
{
    [DataMember]
    public String Id { get; set; }
    [DataMember]
    public DateTime FechaInicio { get; set; }
    [DataMember]
    public DateTime FechaSalida { get; set; }
    [DataMember]
    public Int32 IdTipoPago { get; set; }
    [DataMember]
    public Decimal Monto { get; set; }

    //Datos para Reportes
    [DataMember]
    public String Dni { get; set; }
    [DataMember]
    public String Huesped { get; set; }
    [DataMember]
    public String Direccion { get; set; }
    [DataMember]
    public Int32 Piso { get; set; }
    [DataMember]
    public String Identificador { get; set; }
}

[DataContract]
[Serializable]
public class ReservaDetalleBE
{
    [DataMember]
    public Int32 Id { get; set; }
    [DataMember]
    public Int32 IdReserva { get; set; }
    [DataMember]
    public Int32 IdAmbiente { get; set; }
}

[DataContract]
[Serializable]
public class ReservaHuespedBE
{
    [DataMember]
    public Int32 Id { get; set; }
    [DataMember]
    public Int32 IdReserva { get; set; }
    [DataMember]
    public Int32 IdHuesped { get; set; }
}