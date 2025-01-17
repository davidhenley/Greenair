
using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore;
using ApplicationCore.Entities;
using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using AutoMapper;
using System.Linq;
using LinqKit;
namespace ApplicationCore.Services
{
    public class FlightService : Service<Flight, FlightDTO, FlightDTO>, IFlightService
    {
        public FlightService(IUnitOfWork _unitOfWork, IMapper _mapper) : base(_unitOfWork, _mapper)
        {

        }

        public async Task<FlightDTO> getFlightAsync(string flight_id)
        {
            var flight = await unitOfWork.Flights.GetByAsync(flight_id);
            return mapper.Map<Flight, FlightDTO>(flight);
        }

        public async Task<IEnumerable<FlightDTO>> getAllFlightAsync()
        {
            var flights = await unitOfWork.Flights.GetAllAsync();
            return mapper.Map<IEnumerable<Flight>, IEnumerable<FlightDTO>>(flights);
        }
        public async Task<IEnumerable<FlightDTO>> getAllAvailableFlightAsync()
        {
            var flights = await unitOfWork.Flights.GetAllAsync();
            flights = flights.Where(m => m.Status == STATUS.AVAILABLE);
            return mapper.Map<IEnumerable<Flight>, IEnumerable<FlightDTO>>(flights);
        }
        public async Task<IEnumerable<FlightDTO>> getAllDisabledFlightAsync()
        {
            var flights = await unitOfWork.Flights.GetAllAsync();
            flights = flights.Where(m => m.Status == STATUS.DISABLED);
            return mapper.Map<IEnumerable<Flight>, IEnumerable<FlightDTO>>(flights);
        }

        //Tim kiem ============================================================================================================================
        private async Task<bool> checkOrderNum(string flight_id, int num)
        {
            var tickets = await this.getAvailableTicketAsync(flight_id);
            return num <= tickets.Count();
        }

        public async Task<IEnumerable<FlightDTO>> searchFlightAsync(string origin_id, string destination_id, DateTime dep_date,
                     int adults_num, int childs_num)
        {
            //Expression<Func<Flight, bool>> predicate = m => true;
            //var predicate = PredicateBuilder.New<Flight>();
            if (!String.IsNullOrEmpty(origin_id) && !String.IsNullOrEmpty(destination_id))
            {
                int num = adults_num + childs_num;
                var res = await this.getAllAvailableFlightAsync();

                res = res.Where(m => Task.Run(() => this.getOriginId(m.FlightId)).GetAwaiter().GetResult().Equals(origin_id))
                    .Where(m => Task.Run(() => this.getDestinationId(m.FlightId)).GetAwaiter().GetResult().Equals(destination_id));
                if (dep_date != null)
                    res = res.Where(m => DateTime.Compare(Task.Run(() => this.getDepDate(m.FlightId)).GetAwaiter().GetResult(), dep_date) >= 0);
                res = res.Where(m => Task.Run(() => this.checkOrderNum(m.FlightId, num)).GetAwaiter().GetResult().Equals(origin_id));

                return res;
            }
            else return null;
        }
        public async Task<IEnumerable<FlightDTO>> getLimitFlightAsync(IEnumerable<FlightDTO> flights, DateTime arr_date)
        {
            await Task.Run(() => true);
            if (arr_date != null)
                flights = flights.Where(m => DateTime.Compare(Task.Run(() => this.getArrDate(m.FlightId)).GetAwaiter().GetResult(), arr_date) <= 0);
            return flights;
        }
        private async Task generateFlightId(Flight flight)
        {
            var res = await unitOfWork.Flights.GetAllAsync();
            flight.FlightId = String.Format("{0:00000}", res.Count());
        }

        public async Task addFlightAsync(FlightDTO flightDto)
        {
            if (await unitOfWork.Flights.GetByAsync(flightDto.FlightId) == null)
            {
                var flight = this.toEntity(flightDto);
                await generateFlightId(flight);
                await unitOfWork.Flights.AddAsync(flight);
                await unitOfWork.CompleteAsync();
            }
        }
        public async Task updateFlightAsync(FlightDTO flightDto)
        {
            if (await unitOfWork.Flights.GetByAsync(flightDto.FlightId) != null)
            {
                var flight = this.toEntity(flightDto);
                await unitOfWork.Flights.UpdateAsync(flight);
            }
            else
            {
                var flight = this.toEntity(flightDto);
                await generateFlightId(flight);
                await unitOfWork.Flights.AddAsync(flight);
            }
            await unitOfWork.CompleteAsync();
        }

        public async Task removeFlightAsync(string flight_id)
        {
            var flight = await unitOfWork.Flights.GetByAsync(flight_id);
            if (flight != null)
            {
                await unitOfWork.Flights.RemoveAsync(flight);
                await unitOfWork.CompleteAsync();
            }
        }

        public async Task removeAllFlightAsync()
        {
            await unitOfWork.Flights.RemoveRangeAsync(await unitOfWork.Flights.GetAllAsync());
        }

        public async Task disableFlightAsync(string flight_id)
        {
            await unitOfWork.Flights.disable(flight_id);
        }

        public async Task activateFlightAsync(string flight_id)
        {
            await unitOfWork.Flights.activate(flight_id);
        }

        public async Task<string> getFirstRouteId(string flight_id)
        {
            return await unitOfWork.Flights.getFirstRouteId(flight_id);
        }
        public async Task<string> getLastRouteId(string flight_id)
        {
            return await unitOfWork.Flights.getLastRouteId(flight_id);
        }
        public async Task<RouteDTO> getFirstRoute(string flight_id)
        {
            var route = await unitOfWork.Routes.GetByAsync(await this.getFirstRouteId(flight_id));
            return mapper.Map<Route, RouteDTO>(route);
        }
        public async Task<RouteDTO> getLastRoute(string flight_id)
        {
            var route = await unitOfWork.Routes.GetByAsync(await this.getLastRouteId(flight_id));
            return mapper.Map<Route, RouteDTO>(route);
        }
        public async Task<string> getOriginId(string flight_id)
        {
            var route = await this.getFirstRoute(flight_id);
            return route.Origin;
        }
        public async Task<string> getDestinationId(string flight_id)
        {
            var route = await this.getLastRoute(flight_id);
            return route.Destination;
        }
        public async Task<AirportDTO> getOrigin(string flight_id)
        {
            var airport = await unitOfWork.Airports.GetByAsync(await this.getOriginId(flight_id));
            return mapper.Map<Airport, AirportDTO>(airport);
        }
        public async Task<AirportDTO> getDestination(string flight_id)
        {
            var airport = await unitOfWork.Airports.GetByAsync(await this.getDestinationId(flight_id));
            return mapper.Map<Airport, AirportDTO>(airport);
        }
        public async Task<DateTime> getArrDate(string flight_id)
        {
            return await unitOfWork.Flights.getArrDate(flight_id);
        }
        public async Task<DateTime> getDepDate(string flight_id)
        {
            return await unitOfWork.Flights.getDepDate(flight_id);
        }
        public async Task<FlightTimeDTO> getTotalFlightTime(string flight_id)
        {
            var dets = await unitOfWork.Flights.getAllFlightDetails(flight_id);
            var time = new FlightTime(0);
            foreach (FlightDetail det in dets)
            {
                var route = await unitOfWork.Routes.GetByAsync(det.RouteId);
                time += route.FlightTime;
            }
            return mapper.Map<FlightTime, FlightTimeDTO>(time);
        }

        //Thao tac voi chi tiet ============================================================================================
        public async Task<FlightDetailDTO> getFllightdetailAsync(string flight_id, int part)
        {
            return mapper.Map<FlightDetail, FlightDetailDTO>(await unitOfWork.Flights.getFlightDetail(flight_id, part));
        }
        public async Task<FlightDetailDTO> getFllightdetailAsync(string flight_id, string flightdetail_id)
        {
            return mapper.Map<FlightDetail, FlightDetailDTO>(await unitOfWork.Flights.getFlightDetail(flight_id, flightdetail_id));
        }
        public async Task<IEnumerable<FlightDetailDTO>> getAllFlightDetailAsync(string flight_id)
        {
            return mapper.Map<IEnumerable<FlightDetail>, IEnumerable<FlightDetailDTO>>(await unitOfWork.Flights.getAllFlightDetails(flight_id));
        }
        private async Task generateDetailId(FlightDetail det)
        {
            if (String.IsNullOrEmpty(det.FlightDetailId))
            {
                var res = await unitOfWork.Flights.getAllFlightDetails(det.FlightId);
                det.FlightDetailId = String.Format("{0:000}", res.Count());
            }
        }
        public DateTime calArrDate(DateTime depDate, FlightTime time)
        {
            return depDate.AddMinutes(time.toMinutes());
        }
        public async Task addFlightDetailAsync(FlightDetailDTO det_dto)
        {
            var det = mapper.Map<FlightDetailDTO, FlightDetail>(det_dto);
            await generateDetailId(det);
            await unitOfWork.Flights.addFlightDetail(det);
            await unitOfWork.CompleteAsync();
        }
        public async Task addFlightDetailRangeAsync(IEnumerable<FlightDetailDTO> dets_dto)
        {
            var dets = mapper.Map<IEnumerable<FlightDetailDTO>, IEnumerable<FlightDetail>>(dets_dto);
            await unitOfWork.Flights.addFlightDetailRange(dets);
            await unitOfWork.CompleteAsync();
        }
        public async Task removeFlightDetailAsync(string flight_id)
        {
            await unitOfWork.Flights.removeFlightDetail(flight_id);
        }
        public async Task removeAllFlightDetailAsync(string flight_id)
        {
            await unitOfWork.Flights.removeAllFlightDetail(flight_id);
        }

        //Thao tac voi ve =======================================================================================
        private async Task generateTicket(string flight_id)
        {
            var flight = await unitOfWork.Flights.GetByAsync(flight_id);
            var plane = await unitOfWork.Planes.GetByAsync(flight.PlaneId);
            if (plane.SeatNum > 396)
            {
                Console.WriteLine("GenerateTicket(): Plane has too many seats!!!");
                return;
            }
            var mod = plane.SeatNum / 4;
            var tickets = new List<Ticket>();
            for (int i = 1; i <= plane.SeatNum; i++)
            {
                switch (i / mod)
                {
                    case 0:
                        tickets.Add(new Ticket(String.Format("A{0:00}", i), flight_id, null, null, null));
                        break;
                    case 1:
                        tickets.Add(new Ticket(String.Format("B{0:00}", i), flight_id, null, null, null));
                        break;
                    case 3:
                        tickets.Add(new Ticket(String.Format("C{0:00}", i), flight_id, null, null, null));
                        break;
                    default:
                        tickets.Add(new Ticket(String.Format("D{0:00}", i), flight_id, null, null, null));
                        break;
                }
            }
            await unitOfWork.Flights.addTicketRange(tickets);
        }
        public async Task<TicketDTO> getTicketAsync(string flight_id, string ticket_id)
        {
            var ticket = await unitOfWork.Flights.getTicket(flight_id, ticket_id);
            return mapper.Map<Ticket, TicketDTO>(ticket);
        }
        public async Task<IEnumerable<TicketDTO>> getAllTicketAsync()
        {
            var tickets = await unitOfWork.Flights.getAllTickets();
            return mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketDTO>>(tickets);
        }
        public async Task<IEnumerable<TicketDTO>> getAllTicketByFlightIdAsync(string flight_id)
        {
            var tickets = await unitOfWork.Flights.getAllTicketsByFlightId(flight_id);
            return mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketDTO>>(tickets);
        }
        public async Task<IEnumerable<TicketDTO>> getAvailableTicketAsync(string flight_id)
        {
            var tickets = await unitOfWork.Flights.getAvailableTickets(flight_id);
            return mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketDTO>>(tickets);
        }
        public async Task<IEnumerable<TicketDTO>> getOrderedTicketAsync(string flight_id)
        {
            var tickets = await unitOfWork.Flights.getOrderedTickets(flight_id);
            return mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketDTO>>(tickets);
        }
        public async Task<IEnumerable<TicketDTO>> getPaidTicketAsync(string flight_id)
        {
            var tickets = await unitOfWork.Flights.getPaidTickets(flight_id);
            return mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketDTO>>(tickets);
        }

        public async Task updateTicket(TicketDTO ticketDto)
        {
            var ticket = await unitOfWork.Flights.getTicket(ticketDto.FlightId, ticketDto.TicketId);
            if (ticket == null) return;
            mapper.Map<TicketDTO, Ticket>(ticketDto, ticket);
            await unitOfWork.CompleteAsync();
        }
        public async Task cancelTicket(string flight_id, string ticket_id)
        {
            var ticket = await unitOfWork.Flights.getTicket(flight_id, ticket_id);
            if (ticket == null) return;
            ticket.CustomerId = null;
            ticket.AssignedCus = null;
            ticket.Status = STATUS.AVAILABLE;
            await unitOfWork.CompleteAsync();
        }

    }
}