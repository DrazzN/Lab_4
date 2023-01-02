const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = input;


int openingPosition = output.IndexOf("<span>");
int closingPosition = output.IndexOf("</span>");

openingPosition += 6;
int length = closingPosition - openingPosition;
quantity = output.Substring(openingPosition, length);

output = output.Replace("<div>", "");
output = output.Replace("</div>", "");
output = output.Replace("trade", "reg");


Console.WriteLine(quantity);
Console.WriteLine(output);

