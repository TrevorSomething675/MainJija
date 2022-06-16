using MainProjectWeb.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProjectWeb.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceIitemsRepositury ServiceItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceIitemsRepositury serviceItemsRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
        }
    }
}
