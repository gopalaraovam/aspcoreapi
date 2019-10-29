using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechWebApi.Models;

namespace TechWebApi.Controllers
{
    
    [Route("api/rmi")]
    public class TechApiController : Controller
    {
        /// <summary>
        /// To return all vehicles list
        /// </summary>
        /// <returns>vehicle list object</returns>
        [HttpGet("vehicles")]
        public List<Vehicle> GetAll()
        {
            return GetAllVehicles();
        }

        /// <summary>
        /// Receives id and get by id from list
        /// </summary>
        /// <param name="id">integer</param>
        /// <returns>vehicle object</returns>
        [HttpGet("vehicles/{id}")]
        public Vehicle GetById(int id)
        {
            Vehicle vehicle = GetAllVehicles().Where(x => x.Id == id).FirstOrDefault();
            return vehicle;
        }

        /// <summary>
        /// Receives id and removes by id from list
        /// </summary>
        /// <param name="id">integer</param>
        /// <returns>Status code and message</returns>
        [HttpDelete("vehicles/{id}")]
        public GeicoBaseModel DeleteById(int id)
        {
            var vehicles = GetAllVehicles();
            Vehicle vehicle = vehicles.Where(x => x.Id == id).FirstOrDefault();
            vehicles.Remove(vehicle);
            GeicoBaseModel baseModel = new GeicoBaseModel();
            baseModel.StatusCode = "200";
            baseModel.Message = "Deleted Successfully";
            return baseModel;
        }

        /// <summary>
        /// To create new vehicle record
        /// </summary>
        /// <returns>vehicle object with status code</returns>
        [HttpPost("vehicles")]
        public Vehicle CreateVehicle([FromBody]Vehicle vehicle)
        {
            var vehicles = GetAllVehicles();
            vehicles.Add(vehicle);
            vehicle.StatusCode = "201";
            vehicle.Message = "Created Successfully";
            return vehicle;
        }

        /// <summary>
        /// To create new vehicle record
        /// </summary>
        /// <returns>vehicle object with status code</returns>
        [HttpPut("vehicles")]
        public Vehicle UpdateVehicle([FromBody]Vehicle vehicle)
        {
            var vehicles = GetAllVehicles();
            vehicles.Add(vehicle);
            vehicle.StatusCode = "204";
            vehicle.Message = "Updated Successfully";
            return vehicle;
        }



        #region private Methods
        /// <summary>
        /// To add static vehicles to list vehicle object
        /// </summary>
        /// <returns>List of all vehicles</returns>
        private List<Vehicle> GetAllVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Vehicle { Id = 1, Name = "BMW", OwnerName = "Gopala Rao", Number = "TS28GG47" });
            vehicles.Add(new Vehicle { Id = 3, Name = "ROVER", OwnerName = "Gopala Rao", Number = "TS28GG41" });
            vehicles.Add(new Vehicle { Id = 3, Name = "JAGUAR", OwnerName = "Gopala Rao", Number = "TS28GG44" });
            vehicles.Add(new Vehicle { Id = 4, Name = "BENZ", OwnerName = "Gopala Rao", Number = "TS28GG46" });
            vehicles.Add(new Vehicle { Id = 5, Name = "PORSE", OwnerName = "Gopala Rao", Number = "TS28GG49" });
            return vehicles;
        }
    }


    #endregion
}