using System;
using System.Collections.Generic;
using System.Text;
using University.Models.EntityModels;
using University.Repositories.Contracts;

namespace University.Repositories.Repository
{
    public class AllocateClassRoomRepository:Repository<AllocateClassRoom>,IAllocateClassRoomRepository
    {
    }
}
