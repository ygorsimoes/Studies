// Pacientes
pacientes = document.querySelectorAll(".paciente")

for (i = 0; i < pacientes.length; i++) {
    paciente = pacientes[i]

    // Peso
    tdPeso = paciente.querySelector(".info-peso")
    peso = tdPeso.textContent

    // Altura
    tdAltura = paciente.querySelector(".info-altura")
    altura = tdAltura.textContent

    // Cálculo do IMC
    imc = peso / (altura * altura)

    // IMC
    tdIMC = paciente.querySelector(".info-imc")
    tdIMC.textContent = imc.toFixed(2)
}