SELECT carro.id as 'Carro ID', t1.traccia as 'Treno In', t2.traccia as 'Treno Out', prodotto.nome as 'Prodotto', 
carro.targa as 'Targa', carro.t_long as 'T_Long', carro.portata as 'Portata', carro.peso_in as 'Peso In', carro.peso_out as 'Peso Out'
FROM carro 
LEFT JOIN treno t1 ON carro.treno_in = t1.id 
LEFT JOIN treno t2 on carro.treno_out = t2.id
LEFT JOIN prodotto on carro.prodotto = prodotto.id