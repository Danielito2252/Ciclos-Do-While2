// Declaramos las variables

string nombreUsuarioGuardado;
string contraseñaUsuarioGuardado;
string nombreUsuario;
string contraseñaUsuario;
int intentos = 0;
bool sesionOk = false;

//Pedimos al usuario ingresar datos - Crear cuenta de usuario
Console.WriteLine("*****Nueva cuenta de usuario*****");
Console.Write("Ingrese su usuario");
nombreUsuarioGuardado = Console.ReadLine();
Console.Write("Ingrese su contraseña");
contraseñaUsuarioGuardado = Console.ReadLine();
Console.WriteLine("***!Cuenta creada correctamente¡");

//Ahora vamos a simular el inicio de sesion

do
{
    Console.WriteLine("***Bienvenido al portal web***");
    Console.WriteLine("Ingrese su usuario");
    nombreUsuario = Console.ReadLine();
    Console.Write("Escriba Contraseña: ");
    contraseñaUsuario = Console.ReadLine();

    if (nombreUsuario.Equals(nombreUsuarioGuardado) && contraseñaUsuario.Equals(contraseñaUsuarioGuardado))
    {
        sesionOk = true;
        Console.WriteLine("¡Inicio de sesion correctamente");
    }
    else
    {
        intentos++;
        Console.WriteLine("Usuario y contraseña incorrecto, vuelba a intentar");
    }

} while (!sesionOk && intentos < 3);
if (sesionOk)
{
    Console.WriteLine("¡Bienvenido al sistema!");
}
else
{
    if (intentos >= 3)
    {
        Console.WriteLine("Haz hecho mas de tres intentos");
    }
}