using System;
using System.Collections.Generic;
using {NameSpace}.Model;
using {NameSpace}.DAL;

namespace {NameSpace}.BLL
{
    public partial class {TableName}{BLLSuffix}
    {
		private readonly {DAL} _dal;

		public {TableName}{BLLSuffix}(string connectionString)
        {
            _dal = new {DAL}(connectionString);
        }

		public List<{Model}> GetAll()
		{
			return _dal.GetAll();
		}

		public {Model} GetModel({Key})
		{
			return _dal.GetModel({KeyParam});
		}

		public int Insert({Model} model)
		{
			return _dal.Insert(model);
		}

		public int Update({Model} model)
		{
			return _dal.Update(model);
		}

		public int Delete({Key})
		{
			return _dal.Delete({KeyParam});
		}
    }
}
