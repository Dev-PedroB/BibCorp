import { Emprestimo } from "src/app/emprestimos"

export class Usuario{
    id: number
    nome: string
    localizacao: string
    email: string
    password: string
    userName:string
    phoneNumber:string
    Emprestimos: Emprestimo[]
    token: string
}
