estudantes = {}

idade_min = nil
idade_max = nil
idade_media = 0

while true do
    print('Matrícula: ')
    matricula = io.read('*n')

    if matricula == 0 then
        break
    end

    print('Nome: ')
    io.read() -- ?? BUG WORKAROUND ??
    nome = io.read()

    print('Idade: ')
    idade = io.read('*n')

    if idade_min == nil then
        idade_min = idade
    elseif idade < idade_min then
        idade_min = idade
    end
    
    if idade_max == nil then
        idade_max = idade
    elseif idade > idade_max then
        idade_max = idade
    end

    idade_media = idade_media + idade

    table.insert(estudantes, {matricula = matricula, nome = nome, idade = idade})
end

idade_media = idade_media / #estudantes

print(string.format('Idade mínima: %i', idade_min))
print(string.format('Idade máxima: %i', idade_max))
print(string.format('Idade média:  %i', idade_media))

table.sort(estudantes, function(a, b) return a.nome < b.nome end)

for i, estudante in pairs(estudantes) do
    print(string.format('Matrícula: %i', estudante.matricula))
    print(string.format('Nome: %q', estudante.nome))
    print(string.format('Idade: %i', estudante.idade))
end