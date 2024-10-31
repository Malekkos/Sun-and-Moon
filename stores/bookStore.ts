
export const useBookStore = defineStore("book", {
  state: () => {
    return {
      standard: [],
      bookOne: {title: "", description: ""},
      bookTwo: {title: "", description: ""},
      bookThree: {title: "", description: ""},
      bookFour: {title: "", description: ""},
    }
  },

  actions: {
    async fetchBooks() {
      const infos:any = await $fetch("https://localhost:7240/api/BookAPI")
      console.log("infos in fetchBooks: ", infos)
      this.standard = infos
      }
  }

})