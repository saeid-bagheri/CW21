using CW21.DAL.Context;
using CW21.DAL.Entities;
using System.Runtime.InteropServices;

namespace CW21.Repositories.Doctors
{
    public class AppointmentRepository
    {
        private readonly AppDbContext _context;

        public AppointmentRepository(AppDbContext context)
        {
            _context = context;
        }
        //public int Create(Appoinment appointment)
        //{
        //    _context.Appoinments.Add(appointment);
        //    _context.SaveChanges();
        //    retrun appointment.id;
        //}
    }
}
