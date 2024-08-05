<!-- 
This will be the about section of a particular book
Can include Name, picture of book, Author, tags(maybe), and a directory
cont. to access all the chapters this book has available.

Getting into more complicated things like view count, rating, comments
cont. can be saved for WAY later.
-->

<!-- 
  Using the keepalive param in definePageMeta so that It wouldn't need a change of state for a recall.
  cont. Just have to remember to make the corresponding changes so it doesn't constantly call the api
  cont constantly. Im thinking a conditional check for if state is currently filled. Navigating to a 
  cont. page other than chapter and the specific book name should hence wipe state so it can be refilled
-->

<!-- 
  Super Important one, <NuxtLink>. Its going to be used a whole heck of a lot. We are going to need one
  cont. for chapter changes, links back to home, links to book browser, Everything.

  Similarily, there is a function to handle dynamic changes just once. at least, I think. Currently, I
  cont. dont know if like invoking the function onclick would properly work. Maybe, I can pass params
  cont. onto the function that would let me be able to do that?
-->

<template>
  <div>
    {{ $route.params.bookname }}
  </div>
  <button @click="navigate(`chapterOne`)" >IDK</button>
</template>

<script lang="ts" setup>
  const route = useRoute()

  definePageMeta({
    title: "",
    keepalive: true,
  })

  function navigate(chapter: string){
    console.log("navigate ran")
    console.log(chapter)
    return navigateTo({
      path: `/${route.params.bookname}/${chapter}`
    })
  }


  route.meta.title = route.params.bookname

</script>

<style>

</style>