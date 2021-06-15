local function create()
    local value = 0
    
    local function inc()
        value = value + 1
        return value        
    end

    return inc
end

local i =  create()
print(i)
print(i())
print(i())

i = create()

print(i)
print(i())
print(i())