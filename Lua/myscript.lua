-- 5) Utilize uma tabela Lua para fazer uma estrutura para armazenar os dados de um
-- departamento de uma empresa:

local Departamento =
{
    Nome = "Compra e venda exterior",
    Responsavel = "Vladmir Brasileiro",
    Telefones =
    {
        "1234-9832",
        "3832-3984",
        "3782-3823",
    },
    Colaboradores =
    {
        "Maria da Penha Santos", "mps@dep.br",
        "Jessika Bragança", "jb@dep.br",
        "Filipino Bergonha", "fb@dep.br"
    }
}

-- Percorre a table Departamento
for key, value in pairs(Departamento) do

    -- Imprime os primeiros keywords
    print(key .. ": ")

    -- Se o tipo do value for diferente de string percorrerá o value.
    if type(value) ~= string then

        -- Pula linha :)
        print()

        -- Percorre o value.
        for key2, value2 in ipairs(value) do

            -- Imprime o novo value.
            print(value2)
        end
    end
end