# dotnet-four-golden-signals

A intenção do projeto é mostrar de uma forma simples como fazer uma monitoria básica de um projeto seguindo a fillosofia dos [Four Golden Signals](https://sre.google/sre-book/monitoring-distributed-systems/), proposto no [livro de SRE do Google](https://sre.google/sre-book/table-of-contents/).

Os quatro sinais são:

* Latência
* Tráfego
* Erros
* Saturação

## Executar o projeto

```
cd FourGoldenSignals/devops
docker-compose up -d
```

## Gerar carga

Pode ser utilizado um aplicativo de carga como o [bombardier](https://github.com/codesenberg/bombardier) para ter as métricas geradas no dashboard.

Sugestão:
```
bombardier -c 1 -d 5m http://localhost:5000/latency
```

Caso queira com alguns erros 500:
```
bombardier -c 1 -d 5m http://localhost:5000/latency/witherror
```

## URLs

### Aplicação de teste

http://localhost:5000/metrics

http://localhost:5000/latency

http://localhost:5000/latency/witherror

### Grafana

http://localhost:3000

Usuário e senha: `admin`

### Prometheus

http://localhost:9090

### Node exporter

http://localhost:9100
