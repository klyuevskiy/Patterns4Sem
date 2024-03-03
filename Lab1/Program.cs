using Lab1.Abstract;
using Lab1.Poops;
using Lab1.Blood;
using Lab1;

// обслужить пациента: взять материал, сделать анализ и сообщить результаты
void ServePatient(IAnalysisFactory factory, IPrinter printer)
{
    // взять материал, позвать врача, сделать анализ
    IAnalysisMaterial material = factory.CreateMaterial();
    IDoctor doctor = factory.CreateDoctor();
    Analysis analysis = doctor.CreateAnalysis(material);
    analysis.Print(printer);
}

// окружение - печать и фабрики для анализов
IPrinter printer = new ConsolePrinter();
IAnalysisFactory[] factories = new IAnalysisFactory[]
{
    new PoopAnalysisFactory(),
    new BloodAnalysisFactory()
};

// количество пациентов
int patientsNumber = 10;

// рандомайзер анализов
Random random = new();

while (patientsNumber-- > 0)
{
    // взять нужную фабрику
    int analysisIndex = random.Next(0, factories.Length);
    IAnalysisFactory factory = factories[analysisIndex];
    ServePatient(factory, printer);
    printer.Print(""); // пустая строка
}
