// go-service.go
package main

import (
    "fmt"
    "net/http"
)

func handler(w http.ResponseWriter, r *http.Request) {
    fmt.Fprintf(w, "Go Service: Concurrent task handled!")
}

func main() {
    http.HandleFunc("/concurrency", handler)
    http.ListenAndServe(":6000", nil)
}
