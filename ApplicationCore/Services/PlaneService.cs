using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using AutoMapper;
using System;
namespace ApplicationCore.Services
{
    public class PlaneService : Service<Plane, PlaneDTO, PlaneDTO>, IPlaneService
    {
        public PlaneService(IUnitOfWork _unitOfWork, IMapper _mapper) : base(_unitOfWork, _mapper)
        {

        }
        //query
        public async Task<PlaneDTO> getPlaneAsync(string plane_id)
        {
            return this.toDto(await unitOfWork.Planes.GetByAsync(plane_id));
        }
        public async Task<IEnumerable<PlaneDTO>> getAllPlaneAsync()
        {
            return this.toDtoRange(await unitOfWork.Planes.GetAllAsync());
        }
        public async Task<IEnumerable<PlaneDTO>> getPlaneByMakerIdAsync(string maker_id)
        {
            return this.toDtoRange(await unitOfWork.Planes.getPlanebyMakerId(maker_id));
        }
        public async Task<String> getPlaneFullname(string plane_id)
        {
            var plane = await unitOfWork.Planes.GetByAsync(plane_id);
            var maker = await unitOfWork.Makers.GetByAsync(plane.MakerId);
            return String.Format("{0}-{1}", maker.MakerName, plane.PlaneId);
        }
        //actions
        private async Task generatePlaneId(Plane plane)
        {
            var res = await unitOfWork.Planes.GetAllAsync();
            plane.PlaneId = String.Format("{0:00000}", res.Count());
        }
        public async Task addPlaneAsync(PlaneDTO dto)
        {
            if (await unitOfWork.Planes.GetByAsync(dto.PlaneId) == null)
            {
                var plane = this.toEntity(dto);
                await this.generatePlaneId(plane);
                await unitOfWork.Planes.AddAsync(plane);
                await unitOfWork.CompleteAsync();
            }
        }
        public async Task removePlaneAsync(string plane_id)
        {
            var plane = await unitOfWork.Planes.GetByAsync(plane_id);
            if (plane != null)
            {
                await unitOfWork.Planes.RemoveAsync(plane);
                await unitOfWork.CompleteAsync();
            }
        }
        public async Task updatePlaneAsync(PlaneDTO dto)
        {
            if (await unitOfWork.Planes.GetByAsync(dto.PlaneId) != null)
            {
                var plane = this.toEntity(dto);
                await unitOfWork.Planes.UpdateAsync(plane);
            }
            else
            {
                var plane = this.toEntity(dto);
                await this.generatePlaneId(plane);
                await unitOfWork.Planes.AddAsync(plane);
            }
            await unitOfWork.CompleteAsync();
        }
    }
}