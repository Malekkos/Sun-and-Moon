<!-- 
First page of many!
This will be home, it will have some jumping off points to other sections of the website, and will
cont. function as a preview of some novels/features. This would be a good time to take from WebNovel;
cont. subpar leadership aside, it has a pretty good homepage IMO.

-->

<!-- 
 ~~~~~~~~~~ SeoMeta ~~~~~~~~~~~~
Another useful feature, useSeoMeta({}). We can use this to define page meanings. Say we use description: "",
cont. this would show in page results when searching for things. We can also use ogImage:, ogDescription:(think
cont. like its summarized description), and more.
We can do the above inline with <Head> elements or <Title> elements, but i prefer putting them in script.
-->

<!-- 
 ~~~~~~~ API ~~~~~~~~~~~~~
Another useful feature, useFetch. Its a built in composable for the script tag, and one we'll use quite a bit.
cont. It acts as the fetcher for all the data from the server we are going to use. The following is how:
  const { data: count } = await useFetch('/api/count')
It seems like we would fetch the data from the url, and then assign it a value with const, the variable being data.
cont. Finally, we would use that data elsewhere in template, simply defined like this: {{ count }}. To put it simply,
cont. its like we are using an inline version of useState from react, just from the script this time.

Next would be the $fetch, and its what useFetch uses. While we would be using useFetch for GETS, we need to use $fetch
cont. for other methods, like POST. This is likely where we would set headers as well, im not sure.

Finally, if we want, we can use useAsyncData(). This does everything above while also giving a field for error. It looks
cont. like so:
  const { data, error } = await useAsyncData('users', () => myGetFunction('users'))
It would parse the responses data and error, while searching at the url 'users'. The function myGetFunction is a $fetch,
cont. and using a $fetch is completely fine in this instance.

An option on these fields, called pick: , is a nice tool to 'pick' out specific data from a large set.

We can also use transform, which would be when we are 'picking' specific data but for an array. Looks like the following:
  transform: (mountains) => {
      return mountains.map(mountain => ({ title: mountain.title, description: mountain.description }))

The above is all inside of our composable.
  -->

<!-- 
THOUGHTS 8/10/2024 10:50PM:
  Currently, after having a peak at how Nuxt Layout works and defining it in meta, the correct measure seems to be having
cont. it change on the seperate layouts, and said changes being reflected on the pages. It would be nice to have a top
cont. level method doing some automated checking, but ultimately, its a time sink with marginal gains to it.
  I'll leave it commented for the time being, if I happen to change my mind while reading documentation  
THOUGHTS 8/17/2024 5:03AM:
  I've had a change of heart with the directory, as well as latest updates, but mostly wiht directory. With the interests
cont. of keeping the top kind of clear of anything but the center piece changing... thing, I'm gonna make it so that its
cont. a kind of persisting navbar that will follow directory changes to any other part of the page besides when reading
cont. a book. It should look good, and thematically would make more sense than having a rinky dink directory that goes 
cont. to other parts of the page(which isn't really needed). As for the updates part, main idea remains, but I'm gonna 
cont. have it persist as well.
  When it comes to whether or not its visible in the reading portion, the directory will but will instead be a minimized 
cont. part. The new updates, however, will be void from the reading section altogether. I'd imagine it would be annoying
cont. to see something like that.
THOUGHTS 8/25/2024 12:33AM:
  The Sun and Moon portion of the header, in my opinion, actually look nice. Its just the & that is causing some heartache.
cont. It just kinda looks bad. I vibe with the idea of the transition being inside of the &, but it wont work if it doesnt
cont. look good. I'm thinking we can just do without the & and simply have the icons, with the implication that they stand
cont. for &. I think it would work a lot better.
  The left side of the project, latest updates and directory, aren't conforming to width changes. Likely, the scroll wont either
  Another thing, the mid of the page is off center with the header portion. Sun is peaking out from the middle a bit more than moon.
cont. However, it should be fixed when we do the sizing changes on directory and LU
  Scroll is on the chopping block for today, rather than removing the &. We are gonna have it unfurl out... hopefully haha. We are gonna
cont. include the introduction to the site, tech-stack currently used, as well as a hint on how to change the site theme(clicking on the
cont. sun in the middle of the words SUN and MOON)
THOUGHTS 8/27/2024 3:45AM:
  Got the scroll pretty much figured out, was easier than I thought. The only issue is that at around 930px screen width, the text goes 
cont. offscreen. At that point, I think it would just be better to remove the scroll altogether. Would just make more sense overall. I 
cont. still have some work to do with the text itself, some more font modifiers, but its practically done. Next, what we need to do is
cont. finish the latest updates thing(or create a box), and then we have some choices. I could either A. Keep filling out this page, which
cont. is probably a no because I kind of want my database finished before that(cus we still aren't sure WHAT data we are gonna be consuming)
cont. . B. Work on fleshing out the other pages in the project. A good deal more realistic, Its just groundworks. or C., step into the belly
cont. of the beast and start creating a server with .net and C#... yikes. It's a hard sell.

-->


<template>
  <NuxtLayout>
    <div id="main">
      <div class="mainWrapper">
        <!-- <div class="logoWrapper"></div> -->

        <div class="bodyWrapper">
          <div class="bodySectionDirecAndUpdates">
            <nav id="homePageDirectory">
              <NuxtLink class="link" to="/home">Home</NuxtLink>
              <NuxtLink class="link" to="/profile.vue">Profile</NuxtLink>
              <NuxtLink class="link" to="/search.vue">Find a book</NuxtLink>
            </nav>
            <header class="LUHeader">Latest Updates</header>
            <div id="homePageLatestUpdates">
              <p>Placeholder for latest updates</p>
            </div>
          </div>
          <main class="bodySectionContent">
            <div>
              <header class="bodyHeader">Featured</header>
              <div class="homePageSection">
                <div v-for="book in bookInfo">
                  {{ console.log(book) }}
                  <h5>{{book.title}}</h5>
                </div>
                <div>
                  <p class="bodyTextImportant"></p>
                  <p class="bodyTextSub">Text for sub</p>
                </div>
              </div>
            </div>
            <div>
              <header class="bodyHeader">Trending</header>
              <div class="homePageSection">
                <p class="bodyTextImportant">Placeholder for Trending</p>
                <p class="bodyTextSub">Text for sub</p>
              </div>
            </div>
            <div>
              <header class="bodyHeader">New Releases</header>
              <div class="homePageSection">
                <p class="bodyTextImportant">Placeholder for New Releases</p>
                <p class="bodyTextSub">Text for sub</p>
              </div>
            </div>
            <div>
              <header class="bodyHeader">New Authors Titles</header>
              <div class="homePageSection">
                <p class="bodyTextImportant">Placeholder for New Authors Titles</p>
                <p class="bodyTextSub">Text for sub</p>
              </div>
            </div>
            <div>
              <header class="bodyHeader">Random Books</header>
              <div class="homePageSection">
                <p class="bodyTextImportant">Placeholder for Random Books</p>
                <p class="bodyTextSub">Text for sub</p>
              </div>
            </div>
          </main>
          <div class="bodySectionScroll">
            <div class="scrollWrapper"> <!--@click="extendScroll" -->
              <img id="papScrollTop" src="../public/papScrollTop.png" />
              <img id="papScrollMid" src="../public/papScrollMid.png" />
              <img id="papScrollBot" class="" src="../public/papScrollBot.png" />
            </div>
            <div class="scrollText">
              <p class="innerTextScroll">Welcome to this website! This is a demo site, taking inspiration from modern
                novel hosting sites.<br /> The fun of this project was not using a single thing I was familiar with.
                AKA, I'm using vue & nuxt, typescript technically, Tailwind, and .net with C#. All are things I've never
                used before! <br /> Click the icon between Sun and Moon to see the main feature of this site</p>
            </div>
          </div>
        </div>
      </div>
    </div>
  </NuxtLayout>
</template>

<script lang="ts" setup>

let bookInfo: any = []

definePageMeta({
  title: "Home page of Sun & Moon",
  layout: "home",
})

await useAsyncData("item", () =>
  $fetch("https://localhost:7240/api/BookAPI")
  .then(res => {
    console.log("this is the response:", res)
    bookInfo = res
  })
  .catch(err => { console.log(err) })
)

</script>

<style lang="postcss" scoped>
@import url('https://fonts.googleapis.com/css2?family=Kavivanar&display=swap');

#main .mainWrapper {
  @apply w-full;
}

.mainWrapper {
  @apply pt-[5rem]
}

.bodyWrapper {
  @apply w-full flex flex-row justify-between;
}

.bodySectionDirecAndUpdates,
.bodySectionContent,
.bodySectionScroll {
  @apply w-4/12 flex flex-col flex-nowrap justify-start items-center;
}

.bodySectionContent {
  @apply w-[60%]
}

.homePageSection {
  @apply flex w-[50vw] h-[20rem] mt-10 bg-[#EEAC00] overflow-hidden border-[#996f14] rounded-lg divide-x flex-row;
}

.bodySectionDirecAndUpdates {
  @apply w-[20%];
}

.bodySectionScroll {
  @apply w-[25%];
}

.bodySectionDirecAndUpdates {
  @apply flex w-[20rem] flex-col items-start ml-2;
}

.bodyHeader {
  @apply text-[1.6rem] text-[#832A0D] top-[2rem] relative border-b-[2px] border-[#996f14];
}

.bodyTextSub {
  @apply text-[0.9rem] text-[#2b200f];
}

#homePageDirectory {
  @apply flex w-[15rem] flex-col mb-[2rem];
}

#homePageLatestUpdates {
  @apply bg-[#EEAC00] w-[15rem] h-[20rem] rounded-lg;
}

.LUHeader {
  @apply text-[1.3rem] text-[#823A0D] border-b-[2px] border-[#996f14] mb-[0.2rem] w-[15rem]
}

.link {
  @apply transition-all ease-in-out hover:bg-[#ffd03b] hover:ml-[0.7rem] hover:border-l-[2px];
  @apply ml-[0.5rem] border-[#EEAC00] pl-[1px];
}

.scrollWrapper {
  @apply flex flex-col items-center;
}

#papScrollMid {
  @apply w-[63.4%] h-[40rem] z-0;
}

#papScrollBot {
  @apply w-[100%] pb-[40rem] bottom-[40rem] overflow-hidden bg-[#FFE7B8] relative z-30 transition-[transform] ease-out duration-[1.5s];
}

.scrollWrapper:hover {
  #papScrollBot {
    @apply translate-y-[40rem]
  }
}

.scrollText {
  @apply w-[60%] z-20 bottom-[80rem] relative pointer-events-none text-center;
}

.innerTextScroll {
  @apply font-['Kavivanar']
}
</style>