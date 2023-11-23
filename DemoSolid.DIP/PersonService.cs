namespace DemoSolid.DIP
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IServiceBus _serviceBus;
        private readonly IErpSyncService _erpSyncService;

        public PersonService(
            IPersonRepository personRepository,
            IServiceBus serviceBus,
            IErpSyncService erpSyncService)
        {
            _personRepository = personRepository;
            _serviceBus = serviceBus;
            _erpSyncService = erpSyncService;
        }

        public void Add(PersonDto dto)
        {
            var person = new Person(dto.Name, dto.Document, dto.BirthDate);

            _personRepository.Add(person);

            _erpSyncService.SyncPerson(person);

            _serviceBus.Publish("name_queue", person);
        }
    }
}
