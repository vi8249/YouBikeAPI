using System;

namespace YouBikeAPI.Dtos
{
    public class HistoryRouteDto
    {
        public Guid Id { get; set; }

        public Guid SourceStationId { get; set; }
        public string SourceName { get; set; }

        public Guid DestinationStationId { get; set; }
        public string DestinationName { get; set; }

        public decimal Cost { get; set; }

        public int BikeId { get; set; }

        public bool CurrentRoute { get; set; }

        public DateTime BorrowTime { get; set; }

        public DateTime ReturnTime { get; set; }

        public double SLat { get; set; }
        public double SLng { get; set; }
        public double DLat { get; set; }
        public double DLng { get; set; }
    }
}
