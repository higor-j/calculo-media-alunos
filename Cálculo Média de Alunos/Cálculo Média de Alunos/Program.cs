using Cálculo_Média_de_Alunos;

Alunos[] notas = new Alunos[6];

Alunos camila = new Alunos(8.8);
Alunos virginia = new Alunos(7.6);
Alunos pedro = new Alunos(5.3);
Alunos nestor = new Alunos(4.1);
Alunos carol = new Alunos(9.1);
Alunos ringo = new Alunos(0.0);

notas[0] = camila;
notas[1] = virginia;
notas[2] = pedro;
notas[3] = nestor;
notas[4] = carol;
notas[5] = ringo;

for (int i = 0; i < notas.Length; i++) {
    if (notas[i].notas <= 10.0 && notas[i].notas >= 7.0) {
        Console.WriteLine($"Notas acima de 7.0: {notas[i].notas} \n");
    } else if (notas[i].notas < 7.0 && notas[i].notas > 0.0) {
        Console.WriteLine($"Notas abaixo de 7.0: {notas[i].notas} \n");
    } else {
        Console.WriteLine($"Nota zerada!: {notas[i].notas}");
    }
}