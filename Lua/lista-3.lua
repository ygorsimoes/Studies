local a = 1
local b = 4
local c = 4

function Raizes(a, b, delta)
    local Raiz1 = (-b + delta ^ (1 / 2)) / (2 * a)
    local Raiz2 = (-b - delta ^ (1 / 2)) / (2 * a)
    return Raiz1, Raiz2
end

function Delta(a, c)
    local Delta = (b ^ 2) - 4 * a * c
    return Delta
end

print(Raizes(a, b, Delta(a, b)))



---------------------------------------------------------------------

local util = {}

local x = 10
local y = 20

function util.Min(x, y)
    if x < y then
        return x
    else
        return y
    end
end

function util.Max(x, y)
    if x > y then
        return x
    else
        return y
    end
end

return util