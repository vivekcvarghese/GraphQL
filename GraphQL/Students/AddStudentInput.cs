namespace SampleGQL.GraphQL.Students{

    public record AddStudentInput(string Name, string Course);
    public record EditStudentInput(int Id, string Name, string Course);

    public record DeleteStudentInput(int Id);
    
}