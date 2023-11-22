namespace DemoSolid.SRP
{
    public class PersonService
    {
        private readonly PersonRepository _personRepository;
        private readonly ServiceBus _serviceBus;
        private readonly ErpSyncService _erpSyncService;

        public PersonService(
            PersonRepository personRepository,
            ServiceBus serviceBus,
            ErpSyncService erpSyncService)
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
