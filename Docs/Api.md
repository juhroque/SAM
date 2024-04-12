GET /courses/{id}

Response:

{
    "sigla": "ADS",
    "nome": "Análise e Desenvolvimento de Sistemas",
    "carga_horaria": 2000,
    "custo": 10000,
    "area": {
        "sigla": "TI",
        "nome": "Tecnologia da Informação"
    }
}


POST /courses 

Request:

{
    "sigla": "ADS",
    "nome": "Análise e Desenvolvimento de Sistemas",
    "carga_horaria": 2000,
    "custo": 10000,
    "area": {
        "sigla": "TI"
    }
}

Response:

{
    "sigla": "ADS",
    "nome": "Análise e Desenvolvimento de Sistemas",
    "carga_horaria": 2000,
    "custo": 10000,
    "area": {
        "sigla": "TI",
        "nome": "Tecnologia da Informação"
    }
}



PUT /courses/{id}

Request:

{
    "sigla": "ADS",
    "nome": "Análise e Desenvolvimento de Sistemas",
    "carga_horaria": 2000,
    "custo": 10000,
    "area": {
        "sigla": "TI"
    }
}

GET /courses/{id}/modules

Response:

[
    {
        "sigla": "POO",
        "nome": "Programação Orientada a Objetos",
        "curso": {
            "sigla": "ADS",
            "nome": "Análise e Desenvolvimento de Sistemas"
        }
    },
    {
        "sigla": "BD",
        "nome": "Banco de Dados",
        "curso": {
            "sigla": "ADS",
            "nome": "Análise e Desenvolvimento de Sistemas"
        }
    }
]

POST /modules 

Request:

{
    "sigla": "POO",
    "nome": "Programação Orientada a Objetos",
    "carga_horaria": 80,
    "curso": {
        "sigla": "ADS"
    }
}

GET /modules/{id}/classes

Response:

[
    {
        "sigla": "POO",
        "nome": "POO I",
        "carga_horaria": 80,
        "modulo": {
            "sigla": "POO",
            "nome": "Programação Orientada a Objetos"
        }
    },
    {
        "sigla": "BD",
        "nome": "Banco de Dados Relacionais",
        "carga_horaria": 80,
        "modulo": {
            "sigla": "BD",
            "nome": "Banco de Dados"
        }
    }
]


GET area/{id}

Response:

{
    "sigla": "TI",
    "nome": "Tecnologia da Informação",
    "super_area": {
        "sigla": "EXA",
        "nome": "Ciências Exatas"
    }
}

GET /area/{id}/courses

Response:

[
    {
        "sigla": "ADS",
        "nome": "Análise e Desenvolvimento de Sistemas",
        "carga_horaria": 2000,
        "custo": 10000,
        "area": {
            "sigla": "TI",
            "nome": "Tecnologia da Informação"
        }
    },
    {
        "sigla": "BD",
        "nome": "Banco de Dados",
        "carga_horaria": 2000,
        "custo": 10000,
        "area": {
            "sigla": "TI",
            "nome": "Tecnologia da Informação"
        }
    }
]

POST /classes/

Request:

{
    "sigla": "POO",
    "nome": "POO I",
    "carga_horaria": 80,
    "modulo": {
        "sigla": "POO"
    }
}



GET /courses

Response:

[
    {
        "sigla": "ADS",
        "nome": "Análise e Desenvolvimento de Sistemas",
        "carga_horaria": 2000,
        "custo": 10000,
        "area": {
            "sigla": "TI",
            "nome": "Tecnologia da Informação"
        }
    },
    {
        "sigla": "BD",
        "nome": "Banco de Dados",
        "carga_horaria": 2000,
        "custo": 10000,
        "area": {
            "sigla": "TI",
            "nome": "Tecnologia da Informação"
        }
    }
]

