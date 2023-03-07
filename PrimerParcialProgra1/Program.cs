// See https://aka.ms/new-console-template for more information
using PrimerParcialProgra1.Entidades;
using PrimerParcialProgra1.Negocio;

Usuario user = new Usuario();
ClsUsuario clsUser = new ClsUsuario();
Venta ventas = new Venta();
ClsVenta clsVenta = new ClsVenta();
Console.WriteLine("----------------------------------");
Console.WriteLine("Bienvenido a la Venta de Productos");
Console.WriteLine("----------------------------------\n");
Console.WriteLine("Ingrese su Usuario: ");
user.User = Console.ReadLine();
Console.WriteLine("Ingrese su contraseña: ");
user.Contra = Console.ReadLine();

Console.WriteLine(clsUser.Acceso(user));

bool Resultado = clsUser.Acceso(user);
if (Resultado == true){
    Console.WriteLine("        INICIO DE SECION CORRECTO       ");
    Console.WriteLine("Puedes continuar con el proceso de venta\n");
    
    Console.WriteLine("----------------------------------");
    Console.WriteLine("        Proceso de Compra         ");
    Console.WriteLine("----------------------------------\n");
    
    Console.WriteLine("Ingrese el identificador del producto: ");
    ventas.Identificador = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el nombre del producto: ");
    ventas.Nombre = Console.ReadLine();
    Console.WriteLine("Descripcion del producto: ");
    ventas.Descripcion = Console.ReadLine();
    Console.WriteLine("Ingrese el precio del producto: ");
    ventas.Precio = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad del producto: ");
    ventas.Cantidad = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\n---------------------------------");
    Console.WriteLine("Recibo de Pago");
    Console.WriteLine("---------------------------------");
    Console.WriteLine($"Identificador:           {ventas.Identificador}");
    Console.WriteLine($"Nombre del producto:     {ventas.Nombre}");
    Console.WriteLine($"Descripcion:             {ventas.Descripcion}");
    Console.WriteLine($"Precio Unitario:         {ventas.Precio}");
    Console.WriteLine($"Cantidad de Productos:   {ventas.Cantidad}");
    Console.WriteLine("---------------------------------");
    Console.WriteLine(clsVenta.Cobro(ventas));
    Console.WriteLine("---------------------------------\n");

}else{
    Console.WriteLine("        INICIO DE SESION INCORRECTO        ");
    Console.WriteLine("Nombre de usuario y/o contraseña incorrecta\n");

}


