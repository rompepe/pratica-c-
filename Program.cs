using clases;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("calculadora/sumar",() => {
    calculadora cualquiercosa = new calculadora();
    return cualquiercosa.Sumar(90,90);
});

app.MapGet("calculadora/Restar",() =>{
    calculadora llamarquebusque = new calculadora();
    return llamarquebusque.Restar(90,90);
});


app.MapGet("calculadora/Multiplicar",() =>{
    calculadora llamarquebusque = new calculadora();
    return llamarquebusque.Multiplicar(90,90);
});

app.MapGet("calculadora/Dividir",()=>{
    calculadora llamarquebusque = new calculadora();
    return llamarquebusque.Dividir(90,90);
});

app.Run();


