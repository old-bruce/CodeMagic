/**
 * Auto Create By Code Magic {DateTime}
 *
 * Code Magic GitHub https://github.com/old-bruce/CodeMagic
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using {NameSpace}.Model
using {NameSpace}.DAL

namespace {NameSpace}.BLL
{
    public class {TableName}{BLLSuffix}
    {
		#region Auto Create By Code Magic

		private {DAL} dal = new {DAL}();

		public List<{Model}> GetAll()
		{
			return dal.GetAll();
		}

		public {Model} GetModel({Keys})
		{
			return dal.GetModel({KeysParam});
		}

		public int Insert({Model} model)
		{
			return dal.Insert(model);
		}

		public int Update({Model} model)
		{
			return dal.Update(model);
		}

		public int Delete({Keys})
		{
			return dal.Delete({KeysParam});
		}

		#endregion
    }
}