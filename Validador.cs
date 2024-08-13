using System.Text.RegularExpressions;

public class Validador
{
  public bool validaCPF(string cpf) {
    
    return cpf.Length == 11 && IsOnlyNumbers(cpf);
  }
  
  private bool IsOnlyNumbers(string input)
  {
    string pattern = @"^\d+$";
    return Regex.IsMatch(input, pattern);
  }
}
