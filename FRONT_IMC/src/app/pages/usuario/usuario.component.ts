import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { Usuario } from "src/app/models/usuarios";

@Component({
  selector: "app-usuario",
  templateUrl: "./usuario.component.html",
  styleUrls: ["./usuario.component.css"],
})
export class UsuarioComponent implements OnInit {
  constructor(private http: HttpClient, private router: Router) {}

  usuarios!: Usuario[];
  id?: number;
  nome?: string;
  nasc?: string;

  ngOnInit(): void {
    this.http
      .get<Usuario[]>("https://localhost:5001/api/usuario/listar")
      .subscribe({
        next: (usuarios) => {
          this.usuarios = usuarios;
        },
      });

    console.log(this.usuarios);
  }

  cadastrar(): void {
    // monta o json
    let usuario: Usuario = {
      nome: this.nome,
      nasc: this.nasc,
    };

    // this.http
    //   .post<Usuario>("https://localhost:5001/api/usuario/cadastrar", usuario)
    //   .subscribe({
    //     next: (usuario) => {},
    //     error: (error) => {
    //       console.error("Algum erro aconteceu!");
    //     },
    //   });

    this.http
      .post<Usuario>("https://localhost:5001/api/clientes/cadastrar", usuario)
      .subscribe({ next: (usuario) => this.usuarios.push(usuario) });

    console.log(usuario);
  }
}
