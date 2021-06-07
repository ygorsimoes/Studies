IdadeMinima = nil
IdadeMaxima = nil
IdadeMedia = 0

Estudantes = {}

while true do
    print('Matrícula: ')
    Matricula = io.read('*n')

    if Matricula == 0 then
        break
    end

    print('Nome: ')
    Nome = io.read()

    io.read()

    print('Idade: ')
    Idade = io.read('*n')

    if IdadeMinima == nil then
        IdadeMinima = Idade
    elseif Idade < IdadeMinima then
        IdadeMinima = Idade
    end
    
    if IdadeMaxima == nil then
        IdadeMaxima = Idade
    elseif Idade > IdadeMaxima then
        IdadeMaxima = Idade
    end

    IdadeMedia = IdadeMedia + Idade

    table.insert(Estudantes, {Matricula = Matricula, Nome = Nome, Idade = Idade})
end

IdadeMedia = IdadeMedia / #Estudantes

print(string.format('Idade mínima: %i', IdadeMinima))
print(string.format('Idade máxima: %i', IdadeMaxima))
print(string.format('Idade média:  %i', IdadeMedia))

table.sort(Estudantes)


for i, estudante in pairs(Estudantes) do
    print(string.format('Matrícula: %i', estudante.Matricula))
    -- print(string.format('Nome: %q', estudante.nome))
    print(string.format('Idade: %i', estudante.Idade))
end