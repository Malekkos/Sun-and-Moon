<!-- 
Layouts are a wrapper around pages. For simplification, this is another way to setup
cont. navbars and footers, just for different pages. 
We WILL be using this, because we want a different look for when you are on home page/browsing pages,
cont.  and a different look when you are going through the actual books themselves.
Design:
 ~ This will have the main logo on top, as well as the standard footer information.
 ~ the navbar/main logo on top will have the cool animation we have in mind... If it works out lol
 ~ Probably, in scroll sections(like when viewing all books/curated sections through user choice),
 cont. we would have the navbar remain but the footer disapear. I'd imagine it would look better that way.
-->



<template>
  <div>
    <slot />
  </div>
</template>

<script lang="ts" setup>

</script>

<style>

</style>